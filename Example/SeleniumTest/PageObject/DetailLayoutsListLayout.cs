using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class DetailLayoutsListLayout : ListLayoutBase
    {

        public DetailLayoutsListLayout(IWebElement element) : base(element) { }

        public static implicit operator DetailLayoutsListLayout(ElementFinder finder) => finder.Find<DetailLayoutsListLayout>();
    }

}
