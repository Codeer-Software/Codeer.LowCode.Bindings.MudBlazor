using Codeer.LowCode.Bindings.MudBlazor.Components;
using Codeer.LowCode.Bindings.MudBlazor.Enums;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudSubmitButtonFieldDesign : SubmitButtonFieldDesign
    {
        [Designer]
        public MudVariant Variant { get; set; }

        [Designer]
        public MudColor Color { get; set; }

        public MudSubmitButtonFieldDesign() => TypeFullName = typeof(MudSubmitButtonFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudSubmitButtonFieldComponent).FullName!;
    }
}
