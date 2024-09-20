using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class WriteListDataListLayout : ListLayoutBase
    {
        public TextFieldDriver Name => ByCssSelector("td[data-name='Name']").Wait();

        public WriteListDataListLayout(IWebElement element) : base(element) { }

        public static implicit operator WriteListDataListLayout(ElementFinder finder) => finder.Find<WriteListDataListLayout>();
    }

    public class WriteListDataListPage : ListPage<WriteListDataListLayout, WriteListDataSearchLayout>
    {

        public WriteListDataListPage(IWebDriver driver) : base(driver) { }

    }

    public static class WriteListDataListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/WriteListData")]
        public static WriteListDataListPage AttachWriteListDataListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/WriteListData");
            return new WriteListDataListPage(driver);
        }

    }

}
