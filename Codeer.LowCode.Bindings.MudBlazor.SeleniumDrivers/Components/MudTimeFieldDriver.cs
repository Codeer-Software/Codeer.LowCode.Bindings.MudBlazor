using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudTimeFieldDriver : ComponentBase
    {
        public TextBoxDriver Input => ByCssSelector("input").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public MudTimeFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator MudTimeFieldDriver(ElementFinder finder) => finder.Find<MudTimeFieldDriver>();
    }
}
