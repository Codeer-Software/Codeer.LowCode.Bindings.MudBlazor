using Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Search
{
    public class MudTimeFieldSearchDriver : ComponentBase
    {
        public MudTimePickerDriver StartTime => ByCssSelector("input[data-search-target='min']").Wait().Find<MudTimePickerDriver>();
        public MudTimePickerDriver EndTime => ByCssSelector("input[data-search-target='max']").Wait().Find<MudTimePickerDriver>();

        public MudTimeFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator MudTimeFieldSearchDriver(ElementFinder finder) =>
            finder.Find<MudTimeFieldSearchDriver>();
    }
}
