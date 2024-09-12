using Codeer.LowCode.Bindings.MudBlazor.Components;
using Codeer.LowCode.Bindings.MudBlazor.Enums;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudBooleanFieldDesign : BooleanFieldDesign
    {
        [Designer]
        public MudColor Color { get; set; }

        public MudBooleanFieldDesign() => TypeFullName = typeof(MudBooleanFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudBooleanFieldComponent).FullName!;
    }
}
