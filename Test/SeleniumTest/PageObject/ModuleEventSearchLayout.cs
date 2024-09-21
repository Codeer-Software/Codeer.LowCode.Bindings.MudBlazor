using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;

namespace SeleniumTest.PageObject
{
    public class ModuleEventSearchLayout : ComponentBase
    {
        public SearchGridDriver SearchGridLayoutGrid => ByCssSelector("div[data-name='SearchGridLayout']").Wait();
        public LabelFieldSearchDriver LabelResult => ByCssSelector("div[data-name='LabelResult']").Wait();
        public BooleanFieldSearchDriver Boolean => ByCssSelector("div[data-name='Boolean']").Wait();

        public ModuleEventSearchLayout(IWebElement element) : base(element) { }

        public static implicit operator ModuleEventSearchLayout(ElementFinder finder) => finder.Find<ModuleEventSearchLayout>();
    }

}
