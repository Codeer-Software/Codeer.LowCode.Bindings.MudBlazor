using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ReadListDataDetailLayout : ComponentBase
    {
        public LabelFieldDriver CodeLabel => ByCssSelector("div[data-name='CodeLabel']").Wait();
        public TextFieldDriver Code => ByCssSelector("div[data-name='Code']").Wait();
        public SearchFieldDriver<ReadListDataControlsSearchLayout> Search => ByCssSelector("div[data-name='Search']").Wait();
        public ListFieldDriver<ReadListDataControlsListLayout> List => ByCssSelector("div[data-name='List']").Wait();
        public SubmitButtonFieldDriver SubmitButton => ByCssSelector("div[data-name='SubmitButton']").Wait();

        public ReadListDataDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator ReadListDataDetailLayout(ElementFinder finder) => finder.Find<ReadListDataDetailLayout>();
    }

    public class ReadListDataDetailPage : DetailPage<ReadListDataDetailLayout>
    {

        public ReadListDataDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class ReadListDataDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/ReadListData/")]
        public static ReadListDataDetailPage AttachReadListDataDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/ReadListData/");
            return new ReadListDataDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<ReadListDataDetailLayout> AttachReadListDataDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='ReadListData']").Wait();

    }

}
