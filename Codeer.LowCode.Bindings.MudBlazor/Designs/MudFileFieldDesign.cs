using Codeer.LowCode.Bindings.MudBlazor.Components;
using MudBlazor;
using Codeer.LowCode.Bindings.MudBlazor.Search;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    [DisableBulkDataUpdate]
    public class MudFileFieldDesign : FileFieldDesign
    {
        [Designer]
        public Variant Variant { get; set; } = Variant.Filled;

        [Designer]
        public Color Color { get; set; }

        public MudFileFieldDesign() => TypeFullName = typeof(MudFileFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudFileFieldComponent).FullName!;
        public override string GetSearchWebComponentTypeFullName() => typeof(MudFileComponent).FullName!;
    }
}
