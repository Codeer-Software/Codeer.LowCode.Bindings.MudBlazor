using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Search
{
    public class MudNumberFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver Min => ByTagName("input:first-child").Wait().Find<TextBoxDriver>();
        public TextBoxDriver Max => ByTagName("input:last-child").Wait().Find<TextBoxDriver>();
        public MudNumberFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator MudNumberFieldSearchDriver(ElementFinder finder) =>
            finder.Find<MudNumberFieldSearchDriver>();
    }
}
