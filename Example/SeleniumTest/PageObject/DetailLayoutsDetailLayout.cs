using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class DetailLayoutsDetailLayout : ComponentBase
    {
        public GridDriver GridGrid => ByCssSelector("div[data-name='Grid']").Wait();
        public TabDriver TabTab => ByCssSelector("div[data-name='Tab']").Wait();
        public TextFieldDriver Text => ByCssSelector("div[data-name='Text']").Wait();
        public DateFieldDriver Date => ByCssSelector("div[data-name='Date']").Wait();
        public DateTimeFieldDriver DateTime => ByCssSelector("div[data-name='DateTime']").Wait();
        public NumberFieldDriver Number => ByCssSelector("div[data-name='Number']").Wait();

        public DetailLayoutsDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator DetailLayoutsDetailLayout(ElementFinder finder) => finder.Find<DetailLayoutsDetailLayout>();
    }

    public class DetailLayoutsDetailPage : DetailPage<DetailLayoutsDetailLayout>
    {

        public DetailLayoutsDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class DetailLayoutsDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/DetailLayouts")]
        public static DetailLayoutsDetailPage AttachDetailLayoutsDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/DetailLayouts");
            return new DetailLayoutsDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<DetailLayoutsDetailLayout> AttachDetailLayoutsDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='DetailLayouts']").Wait();

    }

}
