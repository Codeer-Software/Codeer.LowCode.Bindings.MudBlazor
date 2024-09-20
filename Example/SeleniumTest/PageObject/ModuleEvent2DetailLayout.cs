using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ModuleEvent2DetailLayout : ComponentBase
    {
        public ModuleFieldDriver<ModuleEventDetailLayout> Module => ByCssSelector("div[data-name='Module']").Wait();
        public ListFieldDriver<ModuleEventListLayout> List => ByCssSelector("div[data-name='List']").Wait();
        public DetailListFieldDriver<ModuleEventDetailLayout> DetailList => ByCssSelector("div[data-name='DetailList']").Wait();
        public TileListFieldDriver<ModuleEventDetailLayout> TileList => ByCssSelector("div[data-name='TileList']").Wait();

        public ModuleEvent2DetailLayout(IWebElement element) : base(element) { }

        public static implicit operator ModuleEvent2DetailLayout(ElementFinder finder) => finder.Find<ModuleEvent2DetailLayout>();
    }

    public class ModuleEvent2DetailPage : DetailPage<ModuleEvent2DetailLayout>
    {

        public ModuleEvent2DetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class ModuleEvent2DetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/ModuleEvent2")]
        public static ModuleEvent2DetailPage AttachModuleEvent2DetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/ModuleEvent2");
            return new ModuleEvent2DetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<ModuleEvent2DetailLayout> AttachModuleEvent2Dialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='ModuleEvent2']").Wait();

    }

}
