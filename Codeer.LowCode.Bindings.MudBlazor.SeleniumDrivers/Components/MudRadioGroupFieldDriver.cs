using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudRadioGroupFieldDriver : ComponentBase
    {
        public IWebElement Value => ByTagName("span").Wait().Find();
        public MudRadioGroupFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator MudRadioGroupFieldDriver(ElementFinder finder) => finder.Find<MudRadioGroupFieldDriver>();
    }
}
