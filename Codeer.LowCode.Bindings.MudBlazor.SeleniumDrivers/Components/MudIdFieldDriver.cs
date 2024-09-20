using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudIdFieldDriver : ComponentBase
    {
        public TextBoxDriver Input => ByTagName("input").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public MudIdFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator MudIdFieldDriver(ElementFinder finder) => finder.Find<MudIdFieldDriver>();
    }
}
