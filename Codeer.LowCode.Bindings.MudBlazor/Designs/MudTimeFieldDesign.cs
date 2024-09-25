using Codeer.LowCode.Bindings.MudBlazor.Components;
using MudBlazor;
using Codeer.LowCode.Bindings.MudBlazor.Search;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudTimeFieldDesign : TimeFieldDesign
    {
        [Designer]
        public Variant Variant { get; set; }

        [Designer]
        public Color Color { get; set; }

        [Designer]
        public bool StandardInput { get; set; }

        public MudTimeFieldDesign() => TypeFullName = typeof(MudTimeFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudTimeFieldComponent).FullName!;
        public override string GetSearchWebComponentTypeFullName() => typeof(MudTimeComponent).FullName!;
    }
}
