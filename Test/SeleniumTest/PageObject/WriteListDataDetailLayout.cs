using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class WriteListDataDetailLayout : ComponentBase
    {
        public LabelFieldDriver NameLabel => ByCssSelector("div[data-name='NameLabel']").Wait();
        public TextFieldDriver Name => ByCssSelector("div[data-name='Name']").Wait();
        public ListFieldDriver<WriteListDataControlsListLayout> List => ByCssSelector("div[data-name='List']").Wait();
        public SubmitButtonFieldDriver SubmitButton => ByCssSelector("div[data-name='SubmitButton']").Wait();

        public WriteListDataDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator WriteListDataDetailLayout(ElementFinder finder) => finder.Find<WriteListDataDetailLayout>();
    }

    public class WriteListDataDetailPage : DetailPage<WriteListDataDetailLayout>
    {

        public WriteListDataDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class WriteListDataDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/WriteListData/")]
        public static WriteListDataDetailPage AttachWriteListDataDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/WriteListData/");
            return new WriteListDataDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<WriteListDataDetailLayout> AttachWriteListDataDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='WriteListData']").Wait();

    }

}
