using Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Search
{
    public class MudTextFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver Text => ByCssSelector("div.mud-input-control.mud-input-input-control input").Wait().Find<TextBoxDriver>();
        public MudSelectDriver Match => ByCssSelector("div.mud-input-control.mud-select").Wait().Find<MudSelectDriver>();
        public MudTextFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator MudTextFieldSearchDriver(ElementFinder finder) =>
            finder.Find<MudTextFieldSearchDriver>();
    }
}
