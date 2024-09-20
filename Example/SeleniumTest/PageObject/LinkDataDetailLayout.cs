using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class LinkDataDetailLayout : ComponentBase
    {
        public LabelFieldDriver Header => ByCssSelector("div[data-name='Header']").Wait();
        public LabelFieldDriver CodeLabel => ByCssSelector("div[data-name='CodeLabel']").Wait();
        public TextFieldDriver Code => ByCssSelector("div[data-name='Code']").Wait();
        public LabelFieldDriver NameLabel => ByCssSelector("div[data-name='NameLabel']").Wait();
        public TextFieldDriver Name => ByCssSelector("div[data-name='Name']").Wait();
        public SubmitButtonFieldDriver Submit => ByCssSelector("div[data-name='Submit']").Wait();

        public LinkDataDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator LinkDataDetailLayout(ElementFinder finder) => finder.Find<LinkDataDetailLayout>();
    }

    public class LinkDataDetailPage : DetailPage<LinkDataDetailLayout>
    {

        public LinkDataDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class LinkDataDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/LinkData/")]
        public static LinkDataDetailPage AttachLinkDataDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/LinkData/");
            return new LinkDataDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<LinkDataDetailLayout> AttachLinkDataDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='LinkData']").Wait();

    }

}
