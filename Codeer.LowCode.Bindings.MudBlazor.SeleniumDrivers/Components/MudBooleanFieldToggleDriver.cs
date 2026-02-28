using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudBooleanFieldToggleDriver : ComponentBase
    {
        public MudToggleButtonDriver Toggle => ByCssSelector(".mud-toggle-group button").Find<MudToggleButtonDriver>();
        public IWebElement CheckBox => ByCssSelector(".mud-checkbox").Wait().Find();
        public IWebElement Switch => ByCssSelector(".mud-switch").Wait().Find();
        public IWebElement Label => ByTagName("label").Wait().Find();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();

        public bool Checked => GetChecked();

        public MudBooleanFieldToggleDriver(IWebElement element) : base(element) { }
        public static implicit operator MudBooleanFieldToggleDriver(ElementFinder finder) => finder.Find<MudBooleanFieldToggleDriver>();

        public void Edit(bool b)
        {
            if (Checked == b) return;

            if (HasElement(".mud-toggle-group"))
            {
                Toggle.Element.Click();
            }
            else if (HasElement(".mud-checkbox"))
            {
                CheckBox.Click();
            }
            else if (HasElement(".mud-switch"))
            {
                Switch.Click();
            }
        }

        private bool GetChecked()
        {
            if (HasElement(".mud-toggle-group"))
            {
                return Toggle.IsChecked;
            }
            else if (HasElement(".mud-checkbox"))
            {
                return Element.FindElement(By.CssSelector(".mud-checkbox"))
                    .GetAttribute("class").Contains("mud-checked");
            }
            else if (HasElement(".mud-switch"))
            {
                return Element.FindElement(By.CssSelector(".mud-switch"))
                    .GetAttribute("class").Contains("mud-checked");
            }
            return false;
        }

        private bool HasElement(string cssSelector)
        {
            try
            {
                Element.FindElement(By.CssSelector(cssSelector));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
