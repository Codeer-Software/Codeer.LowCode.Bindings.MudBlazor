using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Search
{
    public class MudTimeFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver StartTime => ByTagName("input:first-child").Wait().Find<TextBoxDriver>();
        public TextBoxDriver EndTime => ByTagName("input:last-child").Wait().Find<TextBoxDriver>();
        public MudTimeFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator MudTimeFieldSearchDriver(ElementFinder finder) =>
            finder.Find<MudTimeFieldSearchDriver>();
    }
}
