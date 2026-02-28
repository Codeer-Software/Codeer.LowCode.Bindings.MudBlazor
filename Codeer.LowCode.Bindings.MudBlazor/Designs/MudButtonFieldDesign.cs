using Codeer.LowCode.Bindings.MudBlazor.Components;
using Codeer.LowCode.Blazor.Repository.Design;
using MudBlazor;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    [IgnoreBaseProperties(nameof(Variant), nameof(ImageResourceSet), nameof(ShowTextInToolTip))]
    public class MudButtonFieldDesign: ButtonFieldDesign
    {
        public MudButtonFieldDesign() => TypeFullName = typeof(MudButtonFieldDesign).FullName!;

        [Designer(DisplayName = "Variant")]
        public Variant MudVariant { get; set; }

        [Designer]
        public Color Color { get; set; }

        public override string GetWebComponentTypeFullName() => typeof(MudButtonFieldComponent).FullName!;
    }
}
