using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class LinkDataSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public LinkDataSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator LinkDataSearchLayout(ElementFinder finder) => finder.Find<LinkDataSearchLayout>();
    }

}
