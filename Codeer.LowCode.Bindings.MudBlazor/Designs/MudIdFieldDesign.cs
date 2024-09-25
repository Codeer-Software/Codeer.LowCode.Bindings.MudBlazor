using Codeer.LowCode.Bindings.MudBlazor.Components;
using MudBlazor;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudIdFieldDesign : IdFieldDesign
    {
        [Designer]
        public Variant Variant { get; set; }

        public MudIdFieldDesign() => TypeFullName = typeof(MudIdFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudIdFieldComponent).FullName!;
    }
}
