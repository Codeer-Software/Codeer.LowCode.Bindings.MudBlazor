using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ModuleFieldDataSimpleListLayout : ListLayoutBase
    {

        public ModuleFieldDataSimpleListLayout(IWebElement element) : base(element) { }

        public static implicit operator ModuleFieldDataSimpleListLayout(ElementFinder finder) => finder.Find<ModuleFieldDataSimpleListLayout>();
    }

}
