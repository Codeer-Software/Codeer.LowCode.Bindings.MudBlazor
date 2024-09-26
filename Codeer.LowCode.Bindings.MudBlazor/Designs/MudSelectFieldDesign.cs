using Codeer.LowCode.Bindings.MudBlazor.Components;
using MudBlazor;
using Codeer.LowCode.Bindings.MudBlazor.Search;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudSelectFieldDesign : SelectFieldDesign
    {
        [Designer]
        public Variant Variant { get; set; }

        [Designer]
        public Color Color { get; set; } = Color.Primary;

        public MudSelectFieldDesign() => TypeFullName = typeof(MudSelectFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudSelectFieldComponent).FullName!;
        public override string GetSearchWebComponentTypeFullName() => typeof(MudSelectComponent).FullName!;
    }
}
