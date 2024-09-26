using Selenium.StandardControls;
using OpenQA.Selenium;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Native
{
    public class MudRadioButtonDriver(IWebElement element) : ControlDriverBase(element)
    {
        public bool Checked => Element.GetAttribute("aria-checked") == "true";
    }
}
