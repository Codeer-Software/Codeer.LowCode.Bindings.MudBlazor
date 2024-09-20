using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ModuleEvent2SearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public ModuleEvent2SearchLayout(IWebElement element) : base(element) { }

        public static implicit operator ModuleEvent2SearchLayout(ElementFinder finder) => finder.Find<ModuleEvent2SearchLayout>();
    }

}
