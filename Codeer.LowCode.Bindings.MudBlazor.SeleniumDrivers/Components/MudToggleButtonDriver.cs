using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudToggleButtonDriver : ComponentBase
    {
        public bool IsChecked => ByTagName("input").Wait().Find().GetAttribute("btn-primary") == "true";

        public MudToggleButtonDriver(IWebElement element) : base(element) { }
        public static implicit operator MudToggleButtonDriver(ElementFinder finder) => finder.Find<MudToggleButtonDriver>();
    }
}
