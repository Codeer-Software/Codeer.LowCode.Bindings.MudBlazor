using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class WriteListDataControlsSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public WriteListDataControlsSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator WriteListDataControlsSearchLayout(ElementFinder finder) => finder.Find<WriteListDataControlsSearchLayout>();
    }

}
