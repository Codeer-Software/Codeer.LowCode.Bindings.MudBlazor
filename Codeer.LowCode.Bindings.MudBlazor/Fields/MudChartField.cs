using Codeer.LowCode.Bindings.MudBlazor.Designs;
using Codeer.LowCode.Blazor;
using Codeer.LowCode.Blazor.DataIO;
using Codeer.LowCode.Blazor.DesignLogic;
using Codeer.LowCode.Blazor.OperatingModel;
using Codeer.LowCode.Blazor.Repository.Data;
using Codeer.LowCode.Blazor.Repository.Design;
using Codeer.LowCode.Blazor.Repository.Match;
using Codeer.LowCode.Blazor.Script;
using Codeer.LowCode.Blazor.Script.Internal.ScriptServices;
using MudBlazor;

namespace Codeer.LowCode.Bindings.MudBlazor.Fields
{
    public class MudChartField(MudChartFieldDesign design)
        : FieldBase<MudChartFieldDesign>(design), ISearchResultsViewField
    {
        private List<ChartSeries> _data = new();
        private SearchCondition? _additionalCondition;

        [ScriptHide]
        public Func<SearchCondition?, Task> OnQueryChangedAsync { get; set; } = _ => Task.CompletedTask;

        [ScriptHide]
        public Func<Task> OnSearchDataChangedAsync { get; set; } = async () => await Task.CompletedTask;

        public bool AllowLoad { get; set; } = true;

        [ScriptHide]
        public string ModuleName => Design?.SearchCondition.ModuleName ?? string.Empty;

        public ChartOptions Options { get; } = new();

        public double[] InputData => Series.Select(series => series.Data.FirstOrDefault()).ToArray();

        public string[] InputLabels => Series.Select(series => series.Name).ToArray();

        public List<ChartSeries> Series => (Services.AppInfoService.IsDesignMode ? GetDesignSeries() : _data).ToList();

        public override bool IsModified => false;

        public int Page => 0;

        [ScriptHide]
        public override async Task InitializeDataAsync(FieldDataBase? fieldDataBase)
        {
            if (this.IsInLayout()) await ReloadAsync();
        }

        [ScriptName("SetAdditionalCondition")]
        public async Task SetAdditionalConditionAsync(ModuleSearcher searcher)
            => await SetAdditionalConditionAsync(searcher.GetSearchCondition(), 0);

        [ScriptHide]
        public async Task SetAdditionalConditionAsync(SearchCondition condition, int page)
        {
            if (condition.ModuleName != Design.SearchCondition.ModuleName)
                throw LowCodeException.Create("{0} Invalid Module", Design.SearchCondition.ModuleName,
                    condition.ModuleName);
            _additionalCondition = condition;
            await OnQueryChangedAsync(GetSearchCondition());
        }

        [ScriptHide]
        public override FieldDataBase? GetData() => null;

        [ScriptHide]
        public override FieldSubmitData GetSubmitData() => new();

        [ScriptHide]
        public override async Task SetDataAsync(FieldDataBase? fieldDataBase) => await Task.CompletedTask;

        [ScriptHide]
        public override async Task OnExternalFieldChangedAsync(string fieldName)
        {
            if (!this.IsInLayout()) return;
            var searchCondition = GetSearchCondition();
            if (searchCondition.GetFieldVariableConditions().All(e => new VariableName(e.Variable).FieldName.Root != fieldName)) return;
            await ReloadAsync();
        }

        [ScriptName("Reload")]
        public async Task ReloadAsync()
        {
            Options.ShowLegend = Design.ShowLegend;
            Options.XAxisLines = Design.XAxisLines;
            Options.YAxisLines = Design.YAxisLines;
            Options.YAxisTicks = Design.YAxisTicks;
            Options.MaxNumYAxisTicks = Design.MaxNumYAxisTicks ?? 20;
            Options.YAxisRequireZeroPoint = Design.YAxisRequireZeroPoint;

            var items = await this.GetChildModulesAsync(GetSearchCondition(), ModuleLayoutType.None);
            var data = items.Select(e => e.GetFields().OfType<NumberField>().ToDictionary(x => x.Design.Name, x => x.Value)).ToList();
            var keys = data.FirstOrDefault()?.Keys;
            _data = keys?.ToDictionary(key => key, key => new ChartSeries
            {
                Name = key,
                Data = data.Select(e => ConvertValue(e[key])).ToArray()
            }).Values.ToList() ?? [];

            NotifyStateChanged();
        }

        private SearchCondition GetSearchCondition()
            => Design.SearchCondition.MergeSearchCondition(_additionalCondition);

        private List<ChartSeries> GetDesignSeries() =>
        [
            new ChartSeries { Name = "ChartA", Data = Enumerable.Range(1, 10).Select(d => Math.Sqrt(d) * 3).ToArray() },
            new ChartSeries { Name = "ChartB", Data = Enumerable.Range(1, 10).Select(d => Math.Cos(d * 9 / 57.2958) * 10).ToArray() },
        ];

        private double ConvertValue(object? value)
        {
            if (value is null) return 0;
            if (value is double d) return d;
            if (double.TryParse(value.ToString(), out var result)) return result;
            return 0;
        }
    }
}
