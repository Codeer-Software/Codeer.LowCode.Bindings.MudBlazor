using Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudRadioButtonFieldDriver : ComponentBase
    {
        public MudRadioButtonDriver Input => ByTagName("input").Wait().Find<MudRadioButtonDriver>();
        public IWebElement Label => ByTagName("label").Wait().Find();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public MudRadioButtonFieldDriver(IWebElement element) : base(element) { }

        public static implicit operator MudRadioButtonFieldDriver(ElementFinder finder) =>
            finder.Find<MudRadioButtonFieldDriver>();
    }
}
