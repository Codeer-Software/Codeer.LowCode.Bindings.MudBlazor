using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class FieldEventListLayout : ListLayoutBase
    {
        public IdFieldDriver Id1 => ByCssSelector("td[data-name='Id1']").Wait();

        public FieldEventListLayout(IWebElement element) : base(element) { }

        public static implicit operator FieldEventListLayout(ElementFinder finder) => finder.Find<FieldEventListLayout>();
    }

    public class FieldEventListPage : ListPage<FieldEventListLayout, FieldEventSearchLayout>
    {

        public FieldEventListPage(IWebDriver driver) : base(driver) { }

    }

    public static class FieldEventListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/FieldEvent")]
        public static FieldEventListPage AttachFieldEventListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/FieldEvent");
            return new FieldEventListPage(driver);
        }

    }

}
