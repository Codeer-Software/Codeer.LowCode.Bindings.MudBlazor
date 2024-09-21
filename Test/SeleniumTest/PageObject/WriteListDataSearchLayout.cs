using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class WriteListDataSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public WriteListDataSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator WriteListDataSearchLayout(ElementFinder finder) => finder.Find<WriteListDataSearchLayout>();
    }

}
