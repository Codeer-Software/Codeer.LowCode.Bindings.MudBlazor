using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ReadDataControlsListLayout : ListLayoutBase
    {
        public BooleanFieldDriver Check => ByCssSelector("td[data-name='Check']").Wait();
        public BooleanFieldDriver Toggle => ByCssSelector("td[data-name='Toggle']").Wait();
        public BooleanFieldDriver Switch => ByCssSelector("td[data-name='Switch']").Wait();
        public DateFieldDriver Date => ByCssSelector("td[data-name='Date']").Wait();
        public DateTimeFieldDriver DateTime => ByCssSelector("td[data-name='DateTime']").Wait();
        public LinkFieldDriver<LinkDataListLayout, LinkDataSearchLayout> Link => ByCssSelector("td[data-name='Link']").Wait();
        public NumberFieldDriver Number => ByCssSelector("td[data-name='Number']").Wait();
        public RadioGroupFieldDriver RadioGroup => ByCssSelector("td[data-name='RadioGroup']").Wait();
        public SelectFieldDriver Select => ByCssSelector("td[data-name='Select']").Wait();
        public SelectFieldDriver SelectLink => ByCssSelector("td[data-name='SelectLink']").Wait();
        public TextFieldDriver Text => ByCssSelector("td[data-name='Text']").Wait();
        public TimeFieldDriver Time => ByCssSelector("td[data-name='Time']").Wait();
        public FileFieldDriver File => ByCssSelector("td[data-name='File']").Wait();

        public ReadDataControlsListLayout(IWebElement element) : base(element) { }

        public static implicit operator ReadDataControlsListLayout(ElementFinder finder) => finder.Find<ReadDataControlsListLayout>();
    }

    public class ReadDataControlsListPage : ListPage<ReadDataControlsListLayout, ReadDataControlsSearchLayout>
    {

        public ReadDataControlsListPage(IWebDriver driver) : base(driver) { }

    }

    public static class ReadDataControlsListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/ReadDataControls")]
        public static ReadDataControlsListPage AttachReadDataControlsListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/ReadDataControls");
            return new ReadDataControlsListPage(driver);
        }

    }

}
