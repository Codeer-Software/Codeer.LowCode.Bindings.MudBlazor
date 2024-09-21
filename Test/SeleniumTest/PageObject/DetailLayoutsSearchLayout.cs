using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class DetailLayoutsSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public DetailLayoutsSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator DetailLayoutsSearchLayout(ElementFinder finder) => finder.Find<DetailLayoutsSearchLayout>();
    }

}
