using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ModuleEventDetailLayout : ComponentBase
    {
        public LabelFieldDriver LabelResult => ByCssSelector("div[data-name='LabelResult']").Wait();
        public BooleanFieldDriver Boolean => ByCssSelector("div[data-name='Boolean']").Wait();

        public ModuleEventDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator ModuleEventDetailLayout(ElementFinder finder) => finder.Find<ModuleEventDetailLayout>();
    }

    public class ModuleEventDetailPage : DetailPage<ModuleEventDetailLayout>
    {

        public ModuleEventDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class ModuleEventDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/ModuleEvent/")]
        public static ModuleEventDetailPage AttachModuleEventDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/ModuleEvent/");
            return new ModuleEventDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<ModuleEventDetailLayout> AttachModuleEventDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='ModuleEvent']").Wait();

    }

}
