using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class WriteTileListDataDetailLayout : ComponentBase
    {
        public LabelFieldDriver NameLabel => ByCssSelector("div[data-name='NameLabel']").Wait();
        public TextFieldDriver Name => ByCssSelector("div[data-name='Name']").Wait();
        public TileListFieldDriver<WriteListDataControlsDetailLayout> List => ByCssSelector("div[data-name='List']").Wait();
        public SubmitButtonFieldDriver SubmitButton => ByCssSelector("div[data-name='SubmitButton']").Wait();

        public WriteTileListDataDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator WriteTileListDataDetailLayout(ElementFinder finder) => finder.Find<WriteTileListDataDetailLayout>();
    }

    public class WriteTileListDataDetailPage : DetailPage<WriteTileListDataDetailLayout>
    {

        public WriteTileListDataDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class WriteTileListDataDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/WriteTileListData/")]
        public static WriteTileListDataDetailPage AttachWriteTileListDataDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/WriteTileListData/");
            return new WriteTileListDataDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<WriteTileListDataDetailLayout> AttachWriteTileListDataDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='WriteTileListData']").Wait();

    }

}
