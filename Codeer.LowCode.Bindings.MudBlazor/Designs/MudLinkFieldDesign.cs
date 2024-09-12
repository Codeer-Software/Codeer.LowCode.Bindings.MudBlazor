using Codeer.LowCode.Bindings.MudBlazor.Components;
using Codeer.LowCode.Bindings.MudBlazor.Enums;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudLinkFieldDesign : LinkFieldDesign
    {
        [Designer]
        public MudVariant Variant { get; set; }

        [Designer]
        public MudVariant ButtonVariant { get; set; }

        [Designer]
        public MudColor ButtonColor { get; set; }

        public MudLinkFieldDesign() => TypeFullName = typeof(MudLinkFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudLinkFieldComponent).FullName!;
    }
}
