using Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Native;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Search
{
    public class MudFileFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver FileName => ByCssSelector("input[data-search-target='filename']").Wait().Find<TextBoxDriver>();
        public MudSelectDriver FileNameMatch => ByCssSelector(".mud-input-control.mud-select:has([data-search-target='filenamematch'])").Wait().Find<MudSelectDriver>();
        public TextBoxDriver MinFileSize => ByCssSelector("input[data-search-target='min']").Wait().Find<TextBoxDriver>();
        public TextBoxDriver MaxFileSize => ByCssSelector("input[data-search-target='max']").Wait().Find<TextBoxDriver>();
        public MudFileFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator MudFileFieldSearchDriver(ElementFinder finder) =>
            finder.Find<MudFileFieldSearchDriver>();
    }
}
