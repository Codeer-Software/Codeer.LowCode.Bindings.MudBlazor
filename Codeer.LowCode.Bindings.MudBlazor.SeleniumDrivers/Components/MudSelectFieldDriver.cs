using Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudSelectFieldDriver : ComponentBase
    {
        public MudSelectDriver Select => ByCssSelector(".mud-input-control.mud-select").Wait().Find<MudSelectDriver>();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();

        public MudSelectFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator MudSelectFieldDriver(ElementFinder finder) => finder.Find<MudSelectFieldDriver>();
    }
}
