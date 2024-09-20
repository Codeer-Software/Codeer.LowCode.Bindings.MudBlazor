using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class DisplayTextListLayout : ListLayoutBase
    {
        public IdFieldDriver Id => ByCssSelector("td[data-name='Id']").Wait();
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

        public DisplayTextListLayout(IWebElement element) : base(element) { }

        public static implicit operator DisplayTextListLayout(ElementFinder finder) => finder.Find<DisplayTextListLayout>();
    }

    public class DisplayTextListPage : ListPage<DisplayTextListLayout, DisplayTextSearchLayout>
    {

        public DisplayTextListPage(IWebDriver driver) : base(driver) { }

    }

    public static class DisplayTextListPageExtensions
    {

        [PageObjectIdentify(UrlCompareType.IgnoreQueryEndsWith, "/DisplayText")]
        public static DisplayTextListPage AttachDisplayTextListPage(this IWebDriver driver)
        {
            driver.WaitForUrl(UrlCompareType.IgnoreQueryEndsWith, "/DisplayText");
            return new DisplayTextListPage(driver);
        }

    }

}
