using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Search
{
    public class MudBooleanFieldSearchDriver : ComponentBase
    {
        public DropDownListDriver Select => ByTagName("select").Wait().Find<DropDownListDriver>();
        public MudBooleanFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator MudBooleanFieldSearchDriver(ElementFinder finder) =>
            finder.Find<MudBooleanFieldSearchDriver>();
    }
}
