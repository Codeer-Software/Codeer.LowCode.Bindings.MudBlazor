using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class LinkDataListLayout : ListLayoutBase
    {
        public TextFieldDriver Code => ByCssSelector("td[data-name='Code']").Wait();
        public TextFieldDriver Name => ByCssSelector("td[data-name='Name']").Wait();

        public LinkDataListLayout(IWebElement element) : base(element) { }

        public static implicit operator LinkDataListLayout(ElementFinder finder) => finder.Find<LinkDataListLayout>();
    }

    public class LinkDataListPage : ListPage<LinkDataListLayout, LinkDataSearchLayout>
    {

        public LinkDataListPage(IWebDriver driver) : base(driver) { }

    }

    public static class LinkDataListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/LinkData")]
        public static LinkDataListPage AttachLinkDataListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/LinkData");
            return new LinkDataListPage(driver);
        }

    }

}
