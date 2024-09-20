using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudSubmitButtonFieldDriver : ComponentBase
    {
        public ButtonDriver Submit => ByTagName("button").Wait();
        public MudSubmitButtonFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator MudSubmitButtonFieldDriver(ElementFinder finder) =>
            finder.Find<MudSubmitButtonFieldDriver>();
    }
}
