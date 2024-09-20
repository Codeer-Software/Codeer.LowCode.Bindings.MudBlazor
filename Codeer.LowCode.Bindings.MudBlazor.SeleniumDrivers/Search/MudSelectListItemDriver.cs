using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Search
{
    public class MudSelectListItemDriver : ComponentBase
    {
        public IWebElement Text => ByTagName("label").Wait().Find();
        public CheckBoxDriver CheckBox => ByTagName("input").Wait().Find<CheckBoxDriver>();
        public MudSelectListItemDriver(IWebElement element) : base(element) { }
        public static implicit operator MudSelectListItemDriver(ElementFinder finder) =>
            finder.Find<MudSelectListItemDriver>();
    }
}
