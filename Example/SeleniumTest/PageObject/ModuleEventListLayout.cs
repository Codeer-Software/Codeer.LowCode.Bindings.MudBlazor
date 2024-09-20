using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ModuleEventListLayout : ListLayoutBase
    {
        public BooleanFieldDriver Boolean => ByCssSelector("td[data-name='Boolean']").Wait();
        public LabelFieldDriver LabelResult => ByCssSelector("td[data-name='LabelResult']").Wait();

        public ModuleEventListLayout(IWebElement element) : base(element) { }

        public static implicit operator ModuleEventListLayout(ElementFinder finder) => finder.Find<ModuleEventListLayout>();
    }

    public class ModuleEventListPage : ListPage<ModuleEventListLayout, ModuleEventSearchLayout>
    {

        public ModuleEventListPage(IWebDriver driver) : base(driver) { }

    }

    public static class ModuleEventListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/ModuleEvent")]
        public static ModuleEventListPage AttachModuleEventListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/ModuleEvent");
            return new ModuleEventListPage(driver);
        }

    }

}
