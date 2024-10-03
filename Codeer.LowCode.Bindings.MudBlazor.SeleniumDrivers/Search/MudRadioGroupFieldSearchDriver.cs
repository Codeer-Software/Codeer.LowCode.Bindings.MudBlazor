using Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Search
{
    public class MudRadioGroupFieldSearchDriver : ComponentBase
    {
        public MudSelectDriver Select => ByCssSelector("div:has(> input)").Wait().Find<MudSelectDriver>();
        public MudToggleButtonDriver IsNot => ByCssSelector(".not-button button").Wait().Find<MudToggleButtonDriver>();
        public ItemsControlDriver<MudSelectListItemDriver> MultipleSelect => ByCssSelector("div.input-group .select-list").Wait().Find<ItemsControlDriver<MudSelectListItemDriver>>();
        public MudRadioGroupFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator MudRadioGroupFieldSearchDriver(ElementFinder finder) =>
            finder.Find<MudRadioGroupFieldSearchDriver>();
    }
}
