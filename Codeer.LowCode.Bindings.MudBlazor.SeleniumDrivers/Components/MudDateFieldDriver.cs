using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudDateFieldDriver : ComponentBase
    {
        public TextBoxDriver Input => ByTagName("input").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public MudDateFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator MudDateFieldDriver(ElementFinder finder) => finder.Find<MudDateFieldDriver>();
    }
}
