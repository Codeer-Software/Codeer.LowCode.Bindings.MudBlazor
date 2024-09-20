using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class IsRequiredListDataSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public IsRequiredListDataSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator IsRequiredListDataSearchLayout(ElementFinder finder) => finder.Find<IsRequiredListDataSearchLayout>();
    }

}
