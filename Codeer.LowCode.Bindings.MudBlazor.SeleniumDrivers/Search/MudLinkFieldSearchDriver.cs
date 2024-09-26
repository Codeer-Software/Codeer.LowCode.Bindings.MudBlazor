using Codeer.LowCode.Blazor.SeleniumDrivers;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Search
{
    public class MudLinkFieldSearchDriver<TListLayout, TSearchLayout> : ComponentBase
        where TListLayout : ListLayoutBase
        where TSearchLayout : ComponentBase
    {
        public TextBoxDriver Text => ByTagName("input").Wait().Find<TextBoxDriver>();
        public ButtonDriver Clear => ByCssSelector(".mud-input-adornment button").Wait().Find<ButtonDriver>();
        public ButtonDriver Search => ByCssSelector("div[role='group'] > button.mud-icon-button").Wait();
        public SearchFieldDriver<TSearchLayout> LinkSearch => ByCssSelector("div[data-system='search-field']").Wait();
        public ListFieldDriver<TListLayout> LinkList => ByCssSelector("div[data-system='list-field']").Wait();
        public MudLinkFieldSearchDriver(IWebElement element) : base(element) { }
        public static implicit operator MudLinkFieldSearchDriver<TListLayout, TSearchLayout>(ElementFinder finder) =>
            finder.Find<MudLinkFieldSearchDriver<TListLayout, TSearchLayout>>();
    }
}
