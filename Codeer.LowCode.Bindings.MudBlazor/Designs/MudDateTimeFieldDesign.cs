using Codeer.LowCode.Bindings.MudBlazor.Components;
using MudBlazor;
using Codeer.LowCode.Bindings.MudBlazor.Search;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudDateTimeFieldDesign : DateTimeFieldDesign
    {
        [Designer]
        public Variant Variant { get; set; }

        [Designer]
        public Color Color { get; set; }

        public MudDateTimeFieldDesign() => TypeFullName = typeof(MudDateTimeFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudDateTimeFieldComponent).FullName!;
        public override string GetSearchWebComponentTypeFullName() => typeof(MudDateTimeComponent).FullName!;
    }
}
