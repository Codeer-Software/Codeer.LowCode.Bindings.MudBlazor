using Codeer.LowCode.Bindings.MudBlazor.Components;
using Codeer.LowCode.Bindings.MudBlazor.Enums;
using Codeer.LowCode.Bindings.MudBlazor.Search;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Designs
{
    public class MudTextFieldDesign : TextFieldDesign
    {
        [Designer]
        public MudVariant Variant { get; set; }

        public MudTextFieldDesign() => TypeFullName = typeof(MudTextFieldDesign).FullName!;
        public override string GetWebComponentTypeFullName() => typeof(MudTextFieldComponent).FullName!;
        public override string GetSearchWebComponentTypeFullName() => typeof(MudTextComponent).FullName!;
   }
}
