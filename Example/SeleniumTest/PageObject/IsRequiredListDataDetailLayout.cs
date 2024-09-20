using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class IsRequiredListDataDetailLayout : ComponentBase
    {
        public LabelFieldDriver NameLabel => ByCssSelector("div[data-name='NameLabel']").Wait();
        public TextFieldDriver Name => ByCssSelector("div[data-name='Name']").Wait();
        public ListFieldDriver<IsRequiredListDataControlsListLayout> List => ByCssSelector("div[data-name='List']").Wait();
        public SubmitButtonFieldDriver SubmitButton => ByCssSelector("div[data-name='SubmitButton']").Wait();

        public IsRequiredListDataDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator IsRequiredListDataDetailLayout(ElementFinder finder) => finder.Find<IsRequiredListDataDetailLayout>();
    }

    public class IsRequiredListDataDetailPage : DetailPage<IsRequiredListDataDetailLayout>
    {

        public IsRequiredListDataDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class IsRequiredListDataDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/IsRequiredListData/")]
        public static IsRequiredListDataDetailPage AttachIsRequiredListDataDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/IsRequiredListData/");
            return new IsRequiredListDataDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<IsRequiredListDataDetailLayout> AttachIsRequiredListDataDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='IsRequiredListData']").Wait();

    }

}
