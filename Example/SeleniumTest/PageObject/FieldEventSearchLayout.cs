using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class FieldEventSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();
        public LabelFieldSearchDriver LabelReult => ByCssSelector("div[data-name='LabelReult']").Wait();
        public BooleanFieldSearchDriver Boolean => ByCssSelector("div[data-name='Boolean']").Wait();
        public DateFieldSearchDriver Date => ByCssSelector("div[data-name='Date']").Wait();
        public DateTimeFieldSearchDriver DateTime => ByCssSelector("div[data-name='DateTime']").Wait();
        public DetailListFieldSearchDriver DetailList => ByCssSelector("div[data-name='DetailList']").Wait();
        public LinkFieldSearchDriver<LinkDataListLayout, LinkDataSearchLayout> Link => ByCssSelector("div[data-name='Link']").Wait();
        public ListFieldSearchDriver List => ByCssSelector("div[data-name='List']").Wait();
        public NumberFieldSearchDriver Number => ByCssSelector("div[data-name='Number']").Wait();
        public RadioGroupFieldSearchDriver RadioGroup => ByCssSelector("div[data-name='RadioGroup']").Wait();
        public SelectFieldSearchDriver Select => ByCssSelector("div[data-name='Select']").Wait();
        public TextFieldSearchDriver Text => ByCssSelector("div[data-name='Text']").Wait();
        public TileListFieldSearchDriver TileList => ByCssSelector("div[data-name='TileList']").Wait();
        public TimeFieldSearchDriver Time => ByCssSelector("div[data-name='Time']").Wait();

        public FieldEventSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator FieldEventSearchLayout(ElementFinder finder) => finder.Find<FieldEventSearchLayout>();
    }

}
