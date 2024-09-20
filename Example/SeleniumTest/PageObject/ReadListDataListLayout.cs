using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ReadListDataListLayout : ListLayoutBase
    {
        public TextFieldDriver Code => ByCssSelector("td[data-name='Code']").Wait();

        public ReadListDataListLayout(IWebElement element) : base(element) { }

        public static implicit operator ReadListDataListLayout(ElementFinder finder) => finder.Find<ReadListDataListLayout>();
    }

    public class ReadListDataListPage : ListPage<ReadListDataListLayout, ReadListDataSearchLayout>
    {

        public ReadListDataListPage(IWebDriver driver) : base(driver) { }

    }

    public static class ReadListDataListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/ReadListData")]
        public static ReadListDataListPage AttachReadListDataListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/ReadListData");
            return new ReadListDataListPage(driver);
        }

    }

}
