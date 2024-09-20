using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudBooleanFieldDriver : ComponentBase
    {
        public CheckBoxDriver Check => ByTagName("input").Wait();
        public IWebElement Label => ByTagName("label").Wait().Find();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public MudBooleanFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator MudBooleanFieldDriver(ElementFinder finder) => finder.Find<MudBooleanFieldDriver>();
    }
}
