using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class WriteListDataControlsListLayout : ListLayoutBase
    {
        public BooleanFieldDriver Check => ByCssSelector("td[data-name='Check']").Wait();
        public BooleanFieldDriver Toggle => ByCssSelector("td[data-name='Toggle']").Wait();
        public BooleanFieldDriver Switch => ByCssSelector("td[data-name='Switch']").Wait();
        public DateFieldDriver Date => ByCssSelector("td[data-name='Date']").Wait();
        public DateTimeFieldDriver DateTime => ByCssSelector("td[data-name='DateTime']").Wait();
        public LinkFieldDriver<LinkDataListLayout, LinkDataSearchLayout> Link => ByCssSelector("td[data-name='Link']").Wait();
        public NumberFieldDriver Number => ByCssSelector("td[data-name='Number']").Wait();
        public RadioButtonFieldDriver RadioA => ByCssSelector("td[data-name='RadioA']").Wait();
        public RadioButtonFieldDriver RadioB => ByCssSelector("td[data-name='RadioB']").Wait();
        public RadioButtonFieldDriver RadioC => ByCssSelector("td[data-name='RadioC']").Wait();
        public SelectFieldDriver Select => ByCssSelector("td[data-name='Select']").Wait();
        public SelectFieldDriver SelectLink => ByCssSelector("td[data-name='SelectLink']").Wait();
        public TextFieldDriver Text => ByCssSelector("td[data-name='Text']").Wait();
        public TimeFieldDriver Time => ByCssSelector("td[data-name='Time']").Wait();
        public FileFieldDriver File => ByCssSelector("td[data-name='File']").Wait();

        public WriteListDataControlsListLayout(IWebElement element) : base(element) { }

        public static implicit operator WriteListDataControlsListLayout(ElementFinder finder) => finder.Find<WriteListDataControlsListLayout>();
    }

    public class WriteListDataControlsListPage : ListPage<WriteListDataControlsListLayout, WriteListDataControlsSearchLayout>
    {

        public WriteListDataControlsListPage(IWebDriver driver) : base(driver) { }

    }

    public static class WriteListDataControlsListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/WriteListDataControls")]
        public static WriteListDataControlsListPage AttachWriteListDataControlsListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/WriteListDataControls");
            return new WriteListDataControlsListPage(driver);
        }

    }

}
