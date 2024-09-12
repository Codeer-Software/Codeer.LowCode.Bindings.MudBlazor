using Codeer.LowCode.Bindings.MudBlazor.Components;
using Codeer.LowCode.Bindings.MudBlazor.Enums;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    [IgnoreBaseProperties(nameof(Variant))]
    public class MudButtonFieldDesign: ButtonFieldDesign
    {
        public MudButtonFieldDesign() => TypeFullName = typeof(MudButtonFieldDesign).FullName!;

        [Designer(DisplayName = "Variant")]
        public MudVariant MudVariant { get; set; }

        [Designer]
        public MudColor Color { get; set; }

        public override string GetWebComponentTypeFullName() => typeof(MudButtonFieldComponent).FullName!;
    }
}
