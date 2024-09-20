using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Search
{
    public class MudTextFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver Text => ByTagName("input").Wait().Find<TextBoxDriver>();
        public DropDownListDriver Match => ByTagName("select").Wait().Find<DropDownListDriver>();
        public MudTextFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator MudTextFieldSearchDriver(ElementFinder finder) =>
            finder.Find<MudTextFieldSearchDriver>();
    }
}
