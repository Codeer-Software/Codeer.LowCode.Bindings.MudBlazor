using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ReadTileListDataDetailLayout : ComponentBase
    {
        public LabelFieldDriver CodeLabel => ByCssSelector("div[data-name='CodeLabel']").Wait();
        public TextFieldDriver Code => ByCssSelector("div[data-name='Code']").Wait();
        public SearchFieldDriver<ReadListDataControlsSearchLayout> Search => ByCssSelector("div[data-name='Search']").Wait();
        public TileListFieldDriver<ReadListDataControlsDetailLayout> List => ByCssSelector("div[data-name='List']").Wait();
        public SubmitButtonFieldDriver SubmitButton => ByCssSelector("div[data-name='SubmitButton']").Wait();

        public ReadTileListDataDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator ReadTileListDataDetailLayout(ElementFinder finder) => finder.Find<ReadTileListDataDetailLayout>();
    }

    public class ReadTileListDataDetailPage : DetailPage<ReadTileListDataDetailLayout>
    {

        public ReadTileListDataDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class ReadTileListDataDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/ReadTileListData/")]
        public static ReadTileListDataDetailPage AttachReadTileListDataDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/ReadTileListData/");
            return new ReadTileListDataDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<ReadTileListDataDetailLayout> AttachReadTileListDataDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='ReadTileListData']").Wait();

    }

}
