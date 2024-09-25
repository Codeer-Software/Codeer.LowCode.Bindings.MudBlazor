using Codeer.LowCode.Bindings.MudBlazor.Components;
using MudBlazor;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudRadioButtonFieldDesign : RadioButtonFieldDesign
    {
        [Designer]
        public Color Color { get; set; }

        public MudRadioButtonFieldDesign() => TypeFullName = typeof(MudRadioButtonFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudRadioButtonFieldComponent).FullName!;
    }
}
