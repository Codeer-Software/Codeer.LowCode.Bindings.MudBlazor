using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class HomeSearchLayout : ComponentBase
    {

        public HomeSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator HomeSearchLayout(ElementFinder finder) => finder.Find<HomeSearchLayout>();
    }

}
