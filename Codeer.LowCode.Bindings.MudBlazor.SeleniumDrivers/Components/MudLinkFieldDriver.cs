using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Components
{
    public class MudLinkFieldDriver<TListLayout, TSearchLayout>  : ComponentBase where TListLayout : ListLayoutBase
        where TSearchLayout : ComponentBase
    {
        public TextBoxDriver Input => ByTagName("input").Wait();
        public ButtonDriver Clear => ByCssSelector(".mud-input-adornment button").Wait().Find<ButtonDriver>();
        public ButtonDriver Search => ByCssSelector("button[data-system='search']").Wait();
        public IWebElement ReadOnlyText => ByTagName("span").Wait().Find();
        public SearchFieldDriver<TSearchLayout> LinkSearch => ByCssSelector("div[data-system='search-field']").Wait();
        public ListFieldDriver<TListLayout> LinkList => ByCssSelector("div[data-system='list-field']").Wait();
        public MudLinkFieldDriver(IWebElement element) : base(element) { }
        public static implicit operator MudLinkFieldDriver<TListLayout, TSearchLayout>(ElementFinder finder) => finder.Find<MudLinkFieldDriver<TListLayout, TSearchLayout>>();
    }
}
