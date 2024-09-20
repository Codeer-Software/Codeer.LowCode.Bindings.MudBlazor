using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudDateTimeFieldDriver : ComponentBase
    {
        public TextBoxDriver Input => ByTagName("input").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public MudDateTimeFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator MudDateTimeFieldDriver(ElementFinder finder) => finder.Find<MudDateTimeFieldDriver>();
    }
}
