using Codeer.LowCode.Bindings.MudBlazor.Components;
using MudBlazor;
using Codeer.LowCode.Bindings.MudBlazor.Search;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudDateFieldDesign : DateFieldDesign
    {
        [Designer]
        public Variant Variant { get; set; }

        [Designer]
        public Color Color { get; set; }

        public MudDateFieldDesign() => TypeFullName = typeof(MudDateFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudDateFieldComponent).FullName!;
        public override string GetSearchWebComponentTypeFullName() => typeof(MudDateComponent).FullName!;
    }
}
