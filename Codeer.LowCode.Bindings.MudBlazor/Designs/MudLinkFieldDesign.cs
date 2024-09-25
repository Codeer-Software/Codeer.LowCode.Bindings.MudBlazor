using Codeer.LowCode.Bindings.MudBlazor.Components;
using MudBlazor;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudLinkFieldDesign : LinkFieldDesign
    {
        [Designer]
        public Variant Variant { get; set; }

        [Designer]
        public Variant ButtonVariant { get; set; }

        [Designer]
        public Color ButtonColor { get; set; }

        public MudLinkFieldDesign() => TypeFullName = typeof(MudLinkFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudLinkFieldComponent).FullName!;
    }
}
