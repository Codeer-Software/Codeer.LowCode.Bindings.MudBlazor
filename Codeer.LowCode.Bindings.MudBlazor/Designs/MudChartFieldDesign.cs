using Codeer.LowCode.Bindings.MudBlazor.Components;
using Codeer.LowCode.Bindings.MudBlazor.Fields;
using Codeer.LowCode.Blazor.DesignLogic;
using Codeer.LowCode.Blazor.DesignLogic.Check;
using Codeer.LowCode.Blazor.DesignLogic.Refactor;
using Codeer.LowCode.Blazor.OperatingModel;
using Codeer.LowCode.Blazor.Repository.Data;
using Codeer.LowCode.Blazor.Repository.Design;
using Codeer.LowCode.Blazor.Repository.Match;
using MudBlazor;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudChartFieldDesign() : FieldDesignBase(typeof(MudChartFieldDesign).FullName!), IDisplayName,
        ISearchResultsViewFieldDesign
    {
        [Designer(Scope = DesignerScope.All)]
        public SearchCondition SearchCondition { get; set; } = new();

        [Designer]
        public string DisplayName { get; set; } = string.Empty;

        [Designer]
        public string Height { get; set; } = "500px";

        [Designer]
        [EnumIgnore(ChartType.Timeseries)]
        public ChartType ChartType { get; set; } = ChartType.Line;

        [Designer]
        public bool ShowLegend { get; set; } = true;

        [Designer]
        public bool XAxisLines { get; set; } = true;

        [Designer]
        public bool YAxisLines { get; set; } = true;

        [Designer]
        public int YAxisTicks { get; set; } = 20;

        [Designer]
        public int? MaxNumYAxisTicks { get; set; } = null;

        [Designer]
        public bool YAxisRequireZeroPoint { get; set; } = true;

        public override string GetWebComponentTypeFullName() => typeof(MudChartFieldComponent).FullName!;

        public override string GetSearchWebComponentTypeFullName() => string.Empty;

        public override string GetSearchControlTypeFullName() => string.Empty;

        public override FieldBase CreateField() => new MudChartField(this);

        public override FieldDataBase? CreateData() => null;

        public override List<DesignCheckInfo> CheckDesign(DesignCheckContext context)
        {
            var result = base.CheckDesign(context);
            result.AddRange(SearchCondition.CheckDesign(context, Name, nameof(SearchCondition)));
            return result;
        }

        public override RenameResult ChangeName(RenameContext context) => context.Builder(base.ChangeName(context))
            .AddMatchCondition(SearchCondition)
            .Build();
    }
}
