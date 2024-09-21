using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class WriteDetailListDataListLayout : ListLayoutBase
    {
        public TextFieldDriver Name => ByCssSelector("td[data-name='Name']").Wait();

        public WriteDetailListDataListLayout(IWebElement element) : base(element) { }

        public static implicit operator WriteDetailListDataListLayout(ElementFinder finder) => finder.Find<WriteDetailListDataListLayout>();
    }

    public class WriteDetailListDataListPage : ListPage<WriteDetailListDataListLayout, WriteDetailListDataSearchLayout>
    {

        public WriteDetailListDataListPage(IWebDriver driver) : base(driver) { }

    }

    public static class WriteDetailListDataListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/WriteDetailListData")]
        public static WriteDetailListDataListPage AttachWriteDetailListDataListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/WriteDetailListData");
            return new WriteDetailListDataListPage(driver);
        }

    }

}
