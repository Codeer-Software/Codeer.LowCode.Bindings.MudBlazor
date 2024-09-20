using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class WriteTileListDataListLayout : ListLayoutBase
    {
        public TextFieldDriver Name => ByCssSelector("td[data-name='Name']").Wait();

        public WriteTileListDataListLayout(IWebElement element) : base(element) { }

        public static implicit operator WriteTileListDataListLayout(ElementFinder finder) => finder.Find<WriteTileListDataListLayout>();
    }

    public class WriteTileListDataListPage : ListPage<WriteTileListDataListLayout, WriteTileListDataSearchLayout>
    {

        public WriteTileListDataListPage(IWebDriver driver) : base(driver) { }

    }

    public static class WriteTileListDataListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/WriteTileListData")]
        public static WriteTileListDataListPage AttachWriteTileListDataListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/WriteTileListData");
            return new WriteTileListDataListPage(driver);
        }

    }

}
