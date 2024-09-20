using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudButtonFieldDriver : ComponentBase
    {
        public ButtonDriver Button => ByTagName("button").Wait();
        public MudButtonFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator MudButtonFieldDriver(ElementFinder finder) => finder.Find<MudButtonFieldDriver>();
    }
}
