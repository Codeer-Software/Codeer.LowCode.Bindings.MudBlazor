using Codeer.LowCode.Bindings.MudBlazor.Components;
using Codeer.LowCode.Bindings.MudBlazor.Fields;
using Codeer.LowCode.Blazor.DesignLogic;
using Codeer.LowCode.Blazor.DesignLogic.Check;
using Codeer.LowCode.Blazor.DesignLogic.Refactor;
using Codeer.LowCode.Blazor.OperatingModel;
using Codeer.LowCode.Blazor.Repository.Data;
using Codeer.LowCode.Blazor.Repository.Design;
using Codeer.LowCode.Blazor.Repository.Match;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudCalendarFieldDesign() : FieldDesignBase(typeof(MudCalendarFieldDesign).FullName!), IDisplayName,
        ISearchResultsViewFieldDesign
    {
        [Designer]
        public string DisplayName { get; set; } = string.Empty;

        [Designer(Scope = DesignerScope.All)]
        public SearchCondition SearchCondition { get; set; } = new();

        [Designer(CandidateType = CandidateType.Field)]
        [ModuleMember(Member = $"{nameof(SearchCondition)}.{nameof(SearchCondition.ModuleName)}")]
        [TargetFieldType(Types = [typeof(MudTextFieldDesign)])]
        public string TextField { get; set; } = "";

        [Designer(CandidateType = CandidateType.Field)]
        [ModuleMember(Member = $"{nameof(SearchCondition)}.{nameof(SearchCondition.ModuleName)}")]
        [TargetFieldType(Types = [typeof(DateTimeFieldDesign)])]
        public string StartDateField { get; set; } = "";

        [Designer(CandidateType = CandidateType.Field)]
        [ModuleMember(Member = $"{nameof(SearchCondition)}.{nameof(SearchCondition.ModuleName)}")]
        [TargetFieldType(Types = [typeof(DateTimeFieldDesign)])]
        public string EndDateField { get; set; } = "";

        [Designer(CandidateType = CandidateType.Field)]
        [ModuleMember(Member = $"{nameof(SearchCondition)}.{nameof(SearchCondition.ModuleName)}")]
        [TargetFieldType(Types = [typeof(BooleanFieldDesign)])]
        public string AllDayField { get; set; } = "";

        [Designer]
        public string Height { get; set; } = "500px";

        [Designer(CandidateType = CandidateType.DetailLayout)]
        [Layout(ModuleNameMember = $"{nameof(SearchCondition)}.{nameof(SearchCondition.ModuleName)}")]
        public string DetailLayoutName { get; set; } = string.Empty;

        [Designer(CandidateType = CandidateType.ScriptEvent)]
        public string OnDataChanged { get; set; } = string.Empty;

        public override string GetWebComponentTypeFullName() => typeof(MudCalendarFieldComponent).FullName!;

        public override string GetSearchWebComponentTypeFullName() => string.Empty;

        public override string GetSearchControlTypeFullName() => string.Empty;

        public override FieldBase CreateField() => new MudCalendarField(this);

        public override FieldDataBase? CreateData() => null;


        public override List<DesignCheckInfo> CheckDesign(DesignCheckContext context)
        {
            var result = new List<DesignCheckInfo>();
            context.CheckFieldRelativeFieldExistence(Name, nameof(TextField), SearchCondition.ModuleName,TextField).AddTo(result);
            context.CheckFieldRelativeFieldExistence(Name, nameof(StartDateField), SearchCondition.ModuleName, StartDateField).AddTo(result);
            context.CheckFieldRelativeFieldExistence(Name, nameof(EndDateField), SearchCondition.ModuleName, EndDateField).AddTo(result);
            context.CheckFieldRelativeFieldExistence(Name, nameof(AllDayField), SearchCondition.ModuleName, AllDayField).AddTo(result);
            context.CheckFieldRelativeModuleLayoutExistence(Name, nameof(DetailLayoutName), SearchCondition.ModuleName, DetailLayoutName).AddTo(result);
            context.CheckFieldFunctionExistence(Name, nameof(OnDataChanged), OnDataChanged, null).AddTo(result);
            result.AddRange(SearchCondition.CheckDesign(context, Name, nameof(SearchCondition)));
            return result;
        }

        public override RenameResult ChangeName(RenameContext context) => context.Builder(base.ChangeName(context))
            .AddField(SearchCondition.ModuleName, TextField, value => TextField = value)
            .AddField(SearchCondition.ModuleName, StartDateField, value => StartDateField = value)
            .AddField(SearchCondition.ModuleName, EndDateField, value => EndDateField = value)
            .AddField(SearchCondition.ModuleName, AllDayField, value => AllDayField = value)
            .AddLayout(SearchCondition.ModuleName, ModuleLayoutType.Detail, DetailLayoutName,
                value => DetailLayoutName = value)
            .AddMatchCondition(SearchCondition)
            .Build();
    }
}
