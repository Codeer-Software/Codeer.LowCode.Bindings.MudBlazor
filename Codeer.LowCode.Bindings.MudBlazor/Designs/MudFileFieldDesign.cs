using Codeer.LowCode.Bindings.MudBlazor.Components;
using Codeer.LowCode.Bindings.MudBlazor.Enums;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    [DisableBulkDataUpdate]
    public class MudFileFieldDesign : FileFieldDesign
    {   
        [Designer]
        public MudVariant Variant { get; set; } = MudVariant.Filled;

        [Designer]
        public MudColor Color { get; set; } = MudColor.Default;
        
        public MudFileFieldDesign() => TypeFullName = typeof(MudFileFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudFileFieldComponent).FullName!;
    }
}
