using Codeer.LowCode.Bindings.MudBlazor.Components;
using Codeer.LowCode.Bindings.MudBlazor.Search;
using Codeer.LowCode.Blazor.Repository.Design;
using MudBlazor;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudRadioGroupFieldDesign : RadioGroupFieldDesign
    {
        [Designer]
        public Variant Variant { get; set; }

        public MudRadioGroupFieldDesign() => TypeFullName = typeof(MudRadioGroupFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudRadioGroupFieldComponent).FullName!;
        public override string GetSearchWebComponentTypeFullName() => typeof(MudRadioGroupComponent).FullName!;
    }
}
