using Codeer.LowCode.Bindings.MudBlazor.Components;
using MudBlazor;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudSubmitButtonFieldDesign : SubmitButtonFieldDesign
    {
        [Designer]
        public Variant Variant { get; set; }

        [Designer]
        public Color Color { get; set; }

        public MudSubmitButtonFieldDesign() => TypeFullName = typeof(MudSubmitButtonFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudSubmitButtonFieldComponent).FullName!;
    }
}
