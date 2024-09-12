using Codeer.LowCode.Blazor.Components;
using Codeer.LowCode.Blazor.OperatingModel;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.MudBlazor.Infrastructure
{
    public class MudFieldComponentBase<TField, TMud> : FieldComponentBase<TField>
        where TField : FieldBase where TMud : FieldDesignBase
    {
        protected TMud MudDesign => (TMud)Field.Design;
    }
}
