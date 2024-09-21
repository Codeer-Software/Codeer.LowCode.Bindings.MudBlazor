using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class DisplayTextDetailLayout : ComponentBase
    {
        public LabelFieldDriver Header => ByCssSelector("div[data-name='Header']").Wait();
        public LabelFieldDriver IdLabel => ByCssSelector("div[data-name='IdLabel']").Wait();
        public IdFieldDriver Id => ByCssSelector("div[data-name='Id']").Wait();
        public LabelFieldDriver CheckLabel => ByCssSelector("div[data-name='CheckLabel']").Wait();
        public BooleanFieldDriver Check => ByCssSelector("div[data-name='Check']").Wait();
        public LabelFieldDriver ToggleLabel => ByCssSelector("div[data-name='ToggleLabel']").Wait();
        public BooleanFieldDriver Toggle => ByCssSelector("div[data-name='Toggle']").Wait();
        public LabelFieldDriver SwitchLabel => ByCssSelector("div[data-name='SwitchLabel']").Wait();
        public BooleanFieldDriver Switch => ByCssSelector("div[data-name='Switch']").Wait();
        public LabelFieldDriver DateLabel => ByCssSelector("div[data-name='DateLabel']").Wait();
        public DateFieldDriver Date => ByCssSelector("div[data-name='Date']").Wait();
        public LabelFieldDriver DateTimeLabel => ByCssSelector("div[data-name='DateTimeLabel']").Wait();
        public DateTimeFieldDriver DateTime => ByCssSelector("div[data-name='DateTime']").Wait();
        public LabelFieldDriver LinkLabel => ByCssSelector("div[data-name='LinkLabel']").Wait();
        public LinkFieldDriver<LinkDataListLayout, LinkDataSearchLayout> Link => ByCssSelector("div[data-name='Link']").Wait();
        public LabelFieldDriver NumberLabel => ByCssSelector("div[data-name='NumberLabel']").Wait();
        public NumberFieldDriver Number => ByCssSelector("div[data-name='Number']").Wait();
        public LabelFieldDriver RadioLabel => ByCssSelector("div[data-name='RadioLabel']").Wait();
        public RadioButtonFieldDriver RadioA => ByCssSelector("div[data-name='RadioA']").Wait();
        public RadioButtonFieldDriver RadioB => ByCssSelector("div[data-name='RadioB']").Wait();
        public RadioButtonFieldDriver RadioC => ByCssSelector("div[data-name='RadioC']").Wait();
        public LabelFieldDriver SelectLabel => ByCssSelector("div[data-name='SelectLabel']").Wait();
        public SelectFieldDriver Select => ByCssSelector("div[data-name='Select']").Wait();
        public LabelFieldDriver SelectLinkLabel => ByCssSelector("div[data-name='SelectLinkLabel']").Wait();
        public SelectFieldDriver SelectLink => ByCssSelector("div[data-name='SelectLink']").Wait();
        public LabelFieldDriver TextLabel => ByCssSelector("div[data-name='TextLabel']").Wait();
        public TextFieldDriver Text => ByCssSelector("div[data-name='Text']").Wait();
        public LabelFieldDriver TimeLabel => ByCssSelector("div[data-name='TimeLabel']").Wait();
        public TimeFieldDriver Time => ByCssSelector("div[data-name='Time']").Wait();
        public LabelFieldDriver FileLabel => ByCssSelector("div[data-name='FileLabel']").Wait();
        public FileFieldDriver File => ByCssSelector("div[data-name='File']").Wait();
        public SubmitButtonFieldDriver Submit => ByCssSelector("div[data-name='Submit']").Wait();

        public DisplayTextDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator DisplayTextDetailLayout(ElementFinder finder) => finder.Find<DisplayTextDetailLayout>();
    }

    public class DisplayTextDetailPage : DetailPage<DisplayTextDetailLayout>
    {

        public DisplayTextDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class DisplayTextDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/DisplayText/")]
        public static DisplayTextDetailPage AttachDisplayTextDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/DisplayText/");
            return new DisplayTextDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<DisplayTextDetailLayout> AttachDisplayTextDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='DisplayText']").Wait();

    }

}
