using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class WriteDetailListDataDetailLayout : ComponentBase
    {
        public LabelFieldDriver NameLabel => ByCssSelector("div[data-name='NameLabel']").Wait();
        public TextFieldDriver Name => ByCssSelector("div[data-name='Name']").Wait();
        public DetailListFieldDriver<WriteListDataControlsDetailLayout> List => ByCssSelector("div[data-name='List']").Wait();
        public SubmitButtonFieldDriver SubmitButton => ByCssSelector("div[data-name='SubmitButton']").Wait();

        public WriteDetailListDataDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator WriteDetailListDataDetailLayout(ElementFinder finder) => finder.Find<WriteDetailListDataDetailLayout>();
    }

    public class WriteDetailListDataDetailPage : DetailPage<WriteDetailListDataDetailLayout>
    {

        public WriteDetailListDataDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class WriteDetailListDataDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/WriteDetailListData/")]
        public static WriteDetailListDataDetailPage AttachWriteDetailListDataDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/WriteDetailListData/");
            return new WriteDetailListDataDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<WriteDetailListDataDetailLayout> AttachWriteDetailListDataDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='WriteDetailListData']").Wait();

    }

}
