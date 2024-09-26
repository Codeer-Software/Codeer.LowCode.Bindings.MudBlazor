using Codeer.LowCode.Bindings.MudBlazor.Components;
using MudBlazor;
using Codeer.LowCode.Bindings.MudBlazor.Search;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudBooleanFieldDesign : BooleanFieldDesign
    {
        [Designer]
        public Variant Variant { get; set; }

        [Designer]
        public Color Color { get; set; }

        public MudBooleanFieldDesign() => TypeFullName = typeof(MudBooleanFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudBooleanFieldComponent).FullName!;
        public override string GetSearchWebComponentTypeFullName() => typeof(MudBooleanComponent).FullName!;
    }
}
