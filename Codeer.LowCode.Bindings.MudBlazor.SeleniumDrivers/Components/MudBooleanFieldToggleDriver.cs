using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudBooleanFieldToggleDriver : ComponentBase
    {
        public MudToggleButtonDriver Toggle => ByCssSelector("div.mud-toggle-item").Find<MudToggleButtonDriver>();
        public IWebElement Label => ByTagName("label").Wait().Find();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();

        public bool Checked => GetChecked();

        public MudBooleanFieldToggleDriver(IWebElement element) : base(element) { }
        public static implicit operator MudBooleanFieldToggleDriver(ElementFinder finder) => finder.Find<MudBooleanFieldToggleDriver>();

        public void Edit(bool b)
        {
            if (Toggle.IsChecked == b) return;
            Toggle.Element.Click();
        }

        private bool GetChecked() => Toggle.IsChecked;
    }
}
