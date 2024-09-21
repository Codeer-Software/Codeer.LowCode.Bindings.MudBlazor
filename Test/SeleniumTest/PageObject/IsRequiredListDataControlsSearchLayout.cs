using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class IsRequiredListDataControlsSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public IsRequiredListDataControlsSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator IsRequiredListDataControlsSearchLayout(ElementFinder finder) => finder.Find<IsRequiredListDataControlsSearchLayout>();
    }

}
