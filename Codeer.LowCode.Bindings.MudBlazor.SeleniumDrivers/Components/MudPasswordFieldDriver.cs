using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudPasswordFieldDriver : ComponentBase
    {
        public TextBoxDriver Password => ByTagName("input:not(.password-confirm)").Wait();
        public TextBoxDriver PasswordConfirm => ByCssSelector("input.password-confirm").Wait();
        public MudPasswordFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator MudPasswordFieldDriver(ElementFinder finder) => finder.Find<MudPasswordFieldDriver>();
    }
}
