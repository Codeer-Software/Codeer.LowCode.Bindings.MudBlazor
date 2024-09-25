using Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Search
{
    public class MudBooleanFieldSearchDriver : ComponentBase
    {
        public MudSelectDriver Select => ByCssSelector("div.mud-input-control.mud-select").Wait().Find<MudSelectDriver>();

        public MudBooleanFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator MudBooleanFieldSearchDriver(ElementFinder finder) =>
            finder.Find<MudBooleanFieldSearchDriver>();
    }
}
