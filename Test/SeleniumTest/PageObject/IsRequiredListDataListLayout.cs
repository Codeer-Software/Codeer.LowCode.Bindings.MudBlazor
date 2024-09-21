using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class IsRequiredListDataListLayout : ListLayoutBase
    {
        public TextFieldDriver Name => ByCssSelector("td[data-name='Name']").Wait();

        public IsRequiredListDataListLayout(IWebElement element) : base(element) { }

        public static implicit operator IsRequiredListDataListLayout(ElementFinder finder) => finder.Find<IsRequiredListDataListLayout>();
    }

    public class IsRequiredListDataListPage : ListPage<IsRequiredListDataListLayout, IsRequiredListDataSearchLayout>
    {

        public IsRequiredListDataListPage(IWebDriver driver) : base(driver) { }

    }

    public static class IsRequiredListDataListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/IsRequiredListData")]
        public static IsRequiredListDataListPage AttachIsRequiredListDataListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/IsRequiredListData");
            return new IsRequiredListDataListPage(driver);
        }

    }

}
