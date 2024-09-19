using Codeer.LowCode.Bindings.MudBlazor.Components;
using Codeer.LowCode.Bindings.MudBlazor.Enums;
using Codeer.LowCode.Bindings.MudBlazor.Search;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudDateTimeFieldDesign : DateTimeFieldDesign
    {
        [Designer]
        public MudVariant Variant { get; set; }

        [Designer]
        public MudColor Color { get; set; }

        public MudDateTimeFieldDesign() => TypeFullName = typeof(MudDateTimeFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudDateTimeFieldComponent).FullName!;
        public override string GetSearchWebComponentTypeFullName() => typeof(MudDateTimeComponent).FullName!;
    }
}
