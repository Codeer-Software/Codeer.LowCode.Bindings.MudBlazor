using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ReadListDataSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();
        public LabelFieldSearchDriver ListLabel => ByCssSelector("div[data-name='ListLabel']").Wait();
        public ListFieldSearchDriver List => ByCssSelector("div[data-name='List']").Wait();
        public LabelFieldSearchDriver ListCheckLabel => ByCssSelector("div[data-name='ListCheckLabel']").Wait();
        public BooleanFieldSearchDriver List_Check => ByCssSelector("div[data-name='List.Check']").Wait();
        public LabelFieldSearchDriver ListToggleLabel => ByCssSelector("div[data-name='ListToggleLabel']").Wait();
        public BooleanFieldSearchDriver List_Toggle => ByCssSelector("div[data-name='List.Toggle']").Wait();
        public LabelFieldSearchDriver ListSwitchLabel => ByCssSelector("div[data-name='ListSwitchLabel']").Wait();
        public BooleanFieldSearchDriver List_Switch => ByCssSelector("div[data-name='List.Switch']").Wait();
        public LabelFieldSearchDriver ListDateLabel => ByCssSelector("div[data-name='ListDateLabel']").Wait();
        public DateFieldSearchDriver List_Date => ByCssSelector("div[data-name='List.Date']").Wait();
        public LabelFieldSearchDriver ListDateTimeLabel => ByCssSelector("div[data-name='ListDateTimeLabel']").Wait();
        public DateTimeFieldSearchDriver List_DateTime => ByCssSelector("div[data-name='List.DateTime']").Wait();
        public LabelFieldSearchDriver ListNumberLabel => ByCssSelector("div[data-name='ListNumberLabel']").Wait();
        public NumberFieldSearchDriver List_Number => ByCssSelector("div[data-name='List.Number']").Wait();
        public LabelFieldSearchDriver ListRadioGroupLabel => ByCssSelector("div[data-name='ListRadioGroupLabel']").Wait();
        public RadioGroupFieldSearchDriver List_RadioGroup => ByCssSelector("div[data-name='List.RadioGroup']").Wait();
        public LabelFieldSearchDriver ListSelectLabel => ByCssSelector("div[data-name='ListSelectLabel']").Wait();
        public SelectFieldSearchDriver List_Select => ByCssSelector("div[data-name='List.Select']").Wait();
        public LabelFieldSearchDriver ListTextLabel => ByCssSelector("div[data-name='ListTextLabel']").Wait();
        public TextFieldSearchDriver List_Text => ByCssSelector("div[data-name='List.Text']").Wait();
        public LabelFieldSearchDriver ListTimeLabel => ByCssSelector("div[data-name='ListTimeLabel']").Wait();
        public TimeFieldSearchDriver List_Time => ByCssSelector("div[data-name='List.Time']").Wait();
        public LabelFieldSearchDriver ListFileLabel => ByCssSelector("div[data-name='ListFileLabel']").Wait();
        public FileFieldSearchDriver List_File => ByCssSelector("div[data-name='List.File']").Wait();

        public ReadListDataSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator ReadListDataSearchLayout(ElementFinder finder) => finder.Find<ReadListDataSearchLayout>();
    }

}
