using Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components;
using OpenQA.Selenium;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Search
{
    public class MudDateFieldSearchDriver : ComponentBase
    {
        public MudDateFieldDriver StartMudDate => ByTagName("input:first-child").Wait().Find<MudDateFieldDriver>();
        public MudDateFieldDriver EndMudDate => ByTagName("input:last-child").Wait().Find<MudDateFieldDriver>();
        public MudDateFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator MudDateFieldSearchDriver(ElementFinder finder) =>
            finder.Find<MudDateFieldSearchDriver>();
    }
}
