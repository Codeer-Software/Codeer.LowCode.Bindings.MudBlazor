using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ReadDetailListDataListLayout : ListLayoutBase
    {
        public TextFieldDriver Code => ByCssSelector("td[data-name='Code']").Wait();

        public ReadDetailListDataListLayout(IWebElement element) : base(element) { }

        public static implicit operator ReadDetailListDataListLayout(ElementFinder finder) => finder.Find<ReadDetailListDataListLayout>();
    }

    public class ReadDetailListDataListPage : ListPage<ReadDetailListDataListLayout, ReadDetailListDataSearchLayout>
    {

        public ReadDetailListDataListPage(IWebDriver driver) : base(driver) { }

    }

    public static class ReadDetailListDataListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/ReadDetailListData")]
        public static ReadDetailListDataListPage AttachReadDetailListDataListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/ReadDetailListData");
            return new ReadDetailListDataListPage(driver);
        }

    }

}
