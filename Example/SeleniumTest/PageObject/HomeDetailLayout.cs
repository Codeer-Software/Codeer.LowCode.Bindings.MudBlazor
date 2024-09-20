using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class HomeDetailLayout : ComponentBase
    {
        public LabelFieldDriver TitleLabel => ByCssSelector("div[data-name='TitleLabel']").Wait();
        public ImageViewerFieldDriver LCLogo => ByCssSelector("div[data-name='LCLogo']").Wait();

        public HomeDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator HomeDetailLayout(ElementFinder finder) => finder.Find<HomeDetailLayout>();
    }

    public class HomeDetailPage : DetailPage<HomeDetailLayout>
    {

        public HomeDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class HomeDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/Home")]
        public static HomeDetailPage AttachHomeDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/Home");
            return new HomeDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<HomeDetailLayout> AttachHomeDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='Home']").Wait();

    }

}
