using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Search
{
    public class MudFileFieldSearchDriver : ComponentBase
    {
        public TextBoxDriver FileName => ByTagName("[data-search-target='filename'] input").Wait().Find<TextBoxDriver>();
        public DropDownListDriver FileNameMatch => ByTagName("[data-search-target='filename'] select").Wait().Find<DropDownListDriver>();
        public TextBoxDriver MinFileSize => ByTagName("[data-search-target='file-size'] input:first-child").Wait().Find<TextBoxDriver>();
        public TextBoxDriver MaxFileSize => ByTagName("[data-search-target='file-size'] input:last-child").Wait().Find<TextBoxDriver>();
        public MudFileFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator MudFileFieldSearchDriver(ElementFinder finder) =>
            finder.Find<MudFileFieldSearchDriver>();
    }
}
