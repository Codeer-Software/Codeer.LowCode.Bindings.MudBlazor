using Codeer.LowCode.Bindings.MudBlazor.Components;
using MudBlazor;
using Codeer.LowCode.Bindings.MudBlazor.Search;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudNumberFieldDesign : NumberFieldDesign
    {
        [Designer]
        public Variant Variant { get; set; }

        public MudNumberFieldDesign() => TypeFullName = typeof(MudNumberFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudNumberFieldComponent).FullName!;
        public override string GetSearchWebComponentTypeFullName() => typeof(MudNumberComponent).FullName!;
    }
}
