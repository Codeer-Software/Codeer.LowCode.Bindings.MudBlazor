using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class WriteDetailListDataSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public WriteDetailListDataSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator WriteDetailListDataSearchLayout(ElementFinder finder) => finder.Find<WriteDetailListDataSearchLayout>();
    }

}
