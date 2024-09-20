using Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components;
using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Search
{
    public class MudDateTimeFieldSearchDriver : ComponentBase
    {
        public MudDateFieldDriver StartMudDate => ByTagName("input:first-child").Wait().Find<MudDateFieldDriver>();
        public MudDateFieldDriver EndMudDate => ByTagName("input:last-child").Wait().Find<MudDateFieldDriver>();
        public MudDateTimeFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator MudDateTimeFieldSearchDriver(ElementFinder finder) =>
            finder.Find<MudDateTimeFieldSearchDriver>();
    }
}
