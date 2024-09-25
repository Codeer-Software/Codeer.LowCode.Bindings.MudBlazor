using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudToggleButtonDriver : ComponentBase
    {
        public bool IsChecked => Element.GetAttribute("aria-checked") == "true";

        public MudToggleButtonDriver(IWebElement element) : base(element) { }
        public static implicit operator MudToggleButtonDriver(ElementFinder finder) => finder.Find<MudToggleButtonDriver>();
    }
}
