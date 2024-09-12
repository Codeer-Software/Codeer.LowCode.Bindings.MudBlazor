using Codeer.LowCode.Bindings.MudBlazor.Components;
using Codeer.LowCode.Bindings.MudBlazor.Enums;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudSelectFieldDesign : SelectFieldDesign
    {
        [Designer]
        public MudVariant Variant { get; set; }

        public MudSelectFieldDesign() => TypeFullName = typeof(MudSelectFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudSelectFieldComponent).FullName!;
    }
}
