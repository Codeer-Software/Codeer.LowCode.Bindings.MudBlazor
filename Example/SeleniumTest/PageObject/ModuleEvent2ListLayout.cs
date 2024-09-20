using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ModuleEvent2ListLayout : ListLayoutBase
    {

        public ModuleEvent2ListLayout(IWebElement element) : base(element) { }

        public static implicit operator ModuleEvent2ListLayout(ElementFinder finder) => finder.Find<ModuleEvent2ListLayout>();
    }

}
