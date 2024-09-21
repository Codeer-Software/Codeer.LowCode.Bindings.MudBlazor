using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ModuleFieldDataSimpleDetailLayout : ComponentBase
    {
        public TextFieldDriver Text => ByCssSelector("div[data-name='Text']").Wait();

        public ModuleFieldDataSimpleDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator ModuleFieldDataSimpleDetailLayout(ElementFinder finder) => finder.Find<ModuleFieldDataSimpleDetailLayout>();
    }

    public class ModuleFieldDataSimpleDetailPage : DetailPage<ModuleFieldDataSimpleDetailLayout>
    {

        public ModuleFieldDataSimpleDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class ModuleFieldDataSimpleDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/ModuleFieldDataSimple")]
        public static ModuleFieldDataSimpleDetailPage AttachModuleFieldDataSimpleDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/ModuleFieldDataSimple");
            return new ModuleFieldDataSimpleDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<ModuleFieldDataSimpleDetailLayout> AttachModuleFieldDataSimpleDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='ModuleFieldDataSimple']").Wait();

    }

}
