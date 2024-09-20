using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class FieldEventDetailLayout : ComponentBase
    {
        public LabelFieldDriver LabelReult => ByCssSelector("div[data-name='LabelReult']").Wait();
        public AnchorTagFieldDriver AnchorTag => ByCssSelector("div[data-name='AnchorTag']").Wait();
        public BooleanFieldDriver Boolean => ByCssSelector("div[data-name='Boolean']").Wait();
        public ButtonFieldDriver Button => ByCssSelector("div[data-name='Button']").Wait();
        public DateFieldDriver Date => ByCssSelector("div[data-name='Date']").Wait();
        public DateTimeFieldDriver DateTime => ByCssSelector("div[data-name='DateTime']").Wait();
        public FileFieldDriver File => ByCssSelector("div[data-name='File']").Wait();
        public IdFieldDriver Id1 => ByCssSelector("div[data-name='Id1']").Wait();
        public LinkFieldDriver<LinkDataListLayout, LinkDataSearchLayout> Link => ByCssSelector("div[data-name='Link']").Wait();
        public NumberFieldDriver Number => ByCssSelector("div[data-name='Number']").Wait();
        public PasswordFieldDriver Password => ByCssSelector("div[data-name='Password']").Wait();
        public RadioButtonFieldDriver RadioButtonA => ByCssSelector("div[data-name='RadioButtonA']").Wait();
        public RadioButtonFieldDriver RadioButtonB => ByCssSelector("div[data-name='RadioButtonB']").Wait();
        public SelectFieldDriver Select => ByCssSelector("div[data-name='Select']").Wait();
        public TextFieldDriver Text => ByCssSelector("div[data-name='Text']").Wait();
        public TimeFieldDriver Time => ByCssSelector("div[data-name='Time']").Wait();
        public ModuleFieldDriver<ModuleFieldDataSimpleDetailLayout> Module => ByCssSelector("div[data-name='Module']").Wait();
        public DetailListFieldDriver<WriteDataControlsDetailLayout> DetailList => ByCssSelector("div[data-name='DetailList']").Wait();
        public ListFieldDriver<WriteDataControlsListLayout> List => ByCssSelector("div[data-name='List']").Wait();
        public TileListFieldDriver<WriteDataControlsDetailLayout> TileList => ByCssSelector("div[data-name='TileList']").Wait();

        public FieldEventDetailLayout(IWebElement element) : base(element) { }

        public static implicit operator FieldEventDetailLayout(ElementFinder finder) => finder.Find<FieldEventDetailLayout>();
    }

    public class FieldEventDetailPage : DetailPage<FieldEventDetailLayout>
    {

        public FieldEventDetailPage(IWebDriver driver) : base(driver) { }

    }

    public static class FieldEventDetailPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.Contains, "/FieldEvent/")]
        public static FieldEventDetailPage AttachFieldEventDetailPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.Contains, "/FieldEvent/");
            return new FieldEventDetailPage(driver);
        }

        [ComponentObjectIdentify]
        public static ModuleDialogDriver<FieldEventDetailLayout> AttachFieldEventDialog(this IWebDriver driver)
            => new MappingBase(driver).ByCssSelector("[data-system='module-dialog'][data-module-design='FieldEvent']").Wait();

    }

}
