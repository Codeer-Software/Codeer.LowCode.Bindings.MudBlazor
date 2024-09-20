using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ReadDetailListDataDetailLayout : ComponentBase
    {
        public LabelFieldDriver CodeLabel => ByCssSelector("div[data-name='CodeLabel']").Wait();
        public TextFieldDriver Code => ByCssSelector("div[data-name='Code']").Wait();
        public SearchFieldDriver<ReadListDataControlsSearchLayout> Search => ByCssSelector("div[data-name='Search']").Wait();
        public DetailListFieldDriver<ReadListDataControlsDetailLayout> List => ByCssSelector("div[data-name='List']").Wait();
        public SubmitButtonFieldDriver SubmitButton => ByCssSelector("div[data-name='SubmitButton']").Wait();

        public ReadDetailListDataDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator ReadDetailListDataDetailLayout(ElementFinder finder) => finder.Find<ReadDetailListDataDetailLayout>();
    }

    public class ReadDetailListDataDetailPage : DetailPage<ReadDetailListDataDetailLayout>
    {

        public ReadDetailListDataDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class ReadDetailListDataDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/ReadDetailListData/")]
        public static ReadDetailListDataDetailPage AttachReadDetailListDataDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/ReadDetailListData/");
            return new ReadDetailListDataDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<ReadDetailListDataDetailLayout> AttachReadDetailListDataDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='ReadDetailListData']").Wait();

    }

}
