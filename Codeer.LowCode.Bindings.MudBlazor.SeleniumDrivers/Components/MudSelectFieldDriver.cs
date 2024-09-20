using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudSelectFieldDriver : ComponentBase
    {
        public DropDownListDriver Select => ByTagName("select").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public MudSelectFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator MudSelectFieldDriver(ElementFinder finder) => finder.Find<MudSelectFieldDriver>();
    }
}
