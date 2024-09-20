using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ReadTileListDataListLayout : ListLayoutBase
    {
        public TextFieldDriver Code => ByCssSelector("td[data-name='Code']").Wait();

        public ReadTileListDataListLayout(IWebElement element) : base(element) { }

        public static implicit operator ReadTileListDataListLayout(ElementFinder finder) => finder.Find<ReadTileListDataListLayout>();
    }

    public class ReadTileListDataListPage : ListPage<ReadTileListDataListLayout, ReadTileListDataSearchLayout>
    {

        public ReadTileListDataListPage(IWebDriver driver) : base(driver) { }

    }

    public static class ReadTileListDataListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/ReadTileListData")]
        public static ReadTileListDataListPage AttachReadTileListDataListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/ReadTileListData");
            return new ReadTileListDataListPage(driver);
        }

    }

}
