using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudTextFieldDriver : ComponentBase
    {
        public TextBoxDriver Input => ByTagName("input").Wait();
        public TextAreaDriver TextArea => ByTagName("textarea").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public MudTextFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator MudTextFieldDriver(ElementFinder finder) => finder.Find<MudTextFieldDriver>();
    }
}
