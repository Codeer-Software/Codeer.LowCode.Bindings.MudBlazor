using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudFileFieldDriver : ComponentBase
    {
        public IWebElement Input => ByTagName("input").Wait().Find();
        public AnchorDriver Download => ByTagName("a").Wait();
        public ButtonDriver Delete => ByCssSelector(".d-flex > button").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public IWebElement Image => ByTagName("img").Wait().Find();
        public bool HasFile => Element.FindElements(By.TagName("a")).Any();

        public void Upload(string attachFileFullPath)
        {
            Input.SendKeys(attachFileFullPath);
        }

        public MudFileFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator MudFileFieldDriver(ElementFinder finder) => finder.Find<MudFileFieldDriver>();
    }
}
