using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Native
{
    public class MudTimePickerDriver : ControlDriverBase
    {
        public MudTimePickerDriver(IWebElement element) : base(element) { }

        public void Edit(int hour, int minute)
        {
            Element.Click();

            var popoverContentElement =
                WebDriver.FindElement(By.CssSelector("div[id^='popovercontent-']:has(> div.mud-picker-inline-paper)"));
            //var hourElement = popoverContentElement.FindElement(By.CssSelector());
            JS.ExecuteScript("document.querySelector(arguments[0], ':after').click()", $".mud-time-picker-hour div.mud-picker-stick div[data-stick-value='{hour}']");
            var minuteElement = popoverContentElement.FindElement(By.CssSelector($".mud-time-picker-minute div.mud-picker-stick[data-stick-value='{minute}']"));
            //minuteElement.Click();
        }
    }
}
