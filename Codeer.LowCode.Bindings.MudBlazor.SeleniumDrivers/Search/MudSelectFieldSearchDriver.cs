using Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Search
{
    public class MudSelectFieldSearchDriver : ComponentBase
    {
        public MudSelectDriver Select => ByCssSelector("div.mud-input-control.mud-select").Wait().Find<MudSelectDriver>();
        public MudToggleButtonDriver IsNot => ByCssSelector("div.mud-toggle-item").Wait().Find<MudToggleButtonDriver>();
        public ItemsControlDriver<MudSelectListItemDriver> MultipleSelect => ByCssSelector("div.input-group .select-list").Wait().Find<ItemsControlDriver<MudSelectListItemDriver>>();
        public MudSelectFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator MudSelectFieldSearchDriver(ElementFinder finder) =>
            finder.Find<MudSelectFieldSearchDriver>();
    }
}
