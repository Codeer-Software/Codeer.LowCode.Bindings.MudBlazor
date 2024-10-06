using Codeer.LowCode.Bindings.MudBlazor.Designs;
using Heron.MudCalendar;
using MudBlazor;

namespace Codeer.LowCode.Bindings.MudBlazor.Installer
{
    public static class MudBlazorLoader
    {
        public static void LoadAssemblies()
        {
            typeof(Variant).ToString();
            typeof(MudTextFieldDesign).ToString();
            typeof(MudCalendar).ToString();
            new MudChart();
        }
    }
}
