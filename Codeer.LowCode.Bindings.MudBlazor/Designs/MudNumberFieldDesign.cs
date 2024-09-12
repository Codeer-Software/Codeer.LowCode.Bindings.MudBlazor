using Codeer.LowCode.Bindings.MudBlazor.Components;
using Codeer.LowCode.Bindings.MudBlazor.Enums;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudNumberFieldDesign : NumberFieldDesign
    {
        [Designer]
        public MudVariant Variant { get; set; }

        public MudNumberFieldDesign() => TypeFullName = typeof(MudNumberFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudNumberFieldComponent).FullName!;
    }
}
