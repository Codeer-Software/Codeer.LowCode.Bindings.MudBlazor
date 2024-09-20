using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class WriteDataControlsSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public WriteDataControlsSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator WriteDataControlsSearchLayout(ElementFinder finder) => finder.Find<WriteDataControlsSearchLayout>();
    }

}
