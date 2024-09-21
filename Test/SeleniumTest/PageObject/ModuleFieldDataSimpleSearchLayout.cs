using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ModuleFieldDataSimpleSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();

        public ModuleFieldDataSimpleSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator ModuleFieldDataSimpleSearchLayout(ElementFinder finder) => finder.Find<ModuleFieldDataSimpleSearchLayout>();
    }

}
