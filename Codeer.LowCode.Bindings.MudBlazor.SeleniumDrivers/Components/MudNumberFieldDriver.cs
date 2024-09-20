using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudNumberFieldDriver : ComponentBase
    {
        public TextBoxDriver Input => ByTagName("input").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public MudNumberFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator MudNumberFieldDriver(ElementFinder finder) => finder.Find<MudNumberFieldDriver>();
    }
}
