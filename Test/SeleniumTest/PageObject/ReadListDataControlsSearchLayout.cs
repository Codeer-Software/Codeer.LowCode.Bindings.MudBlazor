using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ReadListDataControlsSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();
        public LabelFieldSearchDriver CheckLabel => ByCssSelector("div[data-name='CheckLabel']").Wait();
        public BooleanFieldSearchDriver Check => ByCssSelector("div[data-name='Check']").Wait();
        public LabelFieldSearchDriver ToggleLabel => ByCssSelector("div[data-name='ToggleLabel']").Wait();
        public BooleanFieldSearchDriver Toggle => ByCssSelector("div[data-name='Toggle']").Wait();
        public LabelFieldSearchDriver SwitchLabel => ByCssSelector("div[data-name='SwitchLabel']").Wait();
        public BooleanFieldSearchDriver Switch => ByCssSelector("div[data-name='Switch']").Wait();
        public LabelFieldSearchDriver DateLabel => ByCssSelector("div[data-name='DateLabel']").Wait();
        public DateFieldSearchDriver Date => ByCssSelector("div[data-name='Date']").Wait();
        public LabelFieldSearchDriver DateTimeLabel => ByCssSelector("div[data-name='DateTimeLabel']").Wait();
        public DateTimeFieldSearchDriver DateTime => ByCssSelector("div[data-name='DateTime']").Wait();
        public LabelFieldSearchDriver LinkLabel => ByCssSelector("div[data-name='LinkLabel']").Wait();
        public LinkFieldSearchDriver<LinkDataListLayout, LinkDataSearchLayout> Link => ByCssSelector("div[data-name='Link']").Wait();
        public LabelFieldSearchDriver NumberLabel => ByCssSelector("div[data-name='NumberLabel']").Wait();
        public NumberFieldSearchDriver Number => ByCssSelector("div[data-name='Number']").Wait();
        public LabelFieldSearchDriver RadioLabel => ByCssSelector("div[data-name='RadioLabel']").Wait();
        public RadioGroupFieldSearchDriver RadioGroup => ByCssSelector("div[data-name='RadioGroup']").Wait();
        public LabelFieldSearchDriver SelectLabel => ByCssSelector("div[data-name='SelectLabel']").Wait();
        public SelectFieldSearchDriver Select => ByCssSelector("div[data-name='Select']").Wait();
        public LabelFieldSearchDriver SelectLinkLabel => ByCssSelector("div[data-name='SelectLinkLabel']").Wait();
        public SelectFieldSearchDriver SelectLink => ByCssSelector("div[data-name='SelectLink']").Wait();
        public LabelFieldSearchDriver TextLabel => ByCssSelector("div[data-name='TextLabel']").Wait();
        public TextFieldSearchDriver Text => ByCssSelector("div[data-name='Text']").Wait();
        public LabelFieldSearchDriver TimeLabel => ByCssSelector("div[data-name='TimeLabel']").Wait();
        public TimeFieldSearchDriver Time => ByCssSelector("div[data-name='Time']").Wait();
        public LabelFieldSearchDriver FileLabel => ByCssSelector("div[data-name='FileLabel']").Wait();
        public FileFieldSearchDriver File => ByCssSelector("div[data-name='File']").Wait();

        public ReadListDataControlsSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator ReadListDataControlsSearchLayout(ElementFinder finder) => finder.Find<ReadListDataControlsSearchLayout>();
    }

}
