using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class HomeListLayout : ListLayoutBase
    {

        public HomeListLayout(IWebElement element) : base(element) { }

        public static implicit operator HomeListLayout(ElementFinder finder) => finder.Find<HomeListLayout>();
    }

}
