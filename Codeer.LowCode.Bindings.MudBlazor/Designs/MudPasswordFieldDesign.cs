using Codeer.LowCode.Bindings.MudBlazor.Components;
using Codeer.LowCode.Bindings.MudBlazor.Enums;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudPasswordFieldDesign : PasswordFieldDesign
    {
        [Designer]
        public MudVariant Variant { get; set; }

        public MudPasswordFieldDesign() => TypeFullName = typeof(MudPasswordFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudPasswordFieldComponent).FullName!;
    }
}
