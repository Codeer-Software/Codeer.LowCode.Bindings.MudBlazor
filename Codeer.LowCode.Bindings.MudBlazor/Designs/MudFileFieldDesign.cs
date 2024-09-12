using Codeer.LowCode.Bindings.MudBlazor.Components;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    [DisableBulkDataUpdate]
    public class MudFileFieldDesign : FileFieldDesign
    {
        public MudFileFieldDesign() => TypeFullName = typeof(MudFileFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudFileFieldComponent).FullName!;
    }
}
