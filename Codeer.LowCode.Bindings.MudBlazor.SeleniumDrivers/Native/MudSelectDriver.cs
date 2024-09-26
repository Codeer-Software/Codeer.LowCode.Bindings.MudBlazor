using Selenium.StandardControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Native
{
    public class MudSelectDriver(IWebElement element) : ControlDriverBase(element)
    {
        public string Text => FindText();

        public void Edit(string value)
        {
            Element.Click();

            for (int i = 0; i < 10; i++)
            {
                var popoverContentElement = WebDriver.FindElement(By.CssSelector("div[id^='popovercontent-']:has(> div.mud-list)"));
                var listItemElements = popoverContentElement.FindElements(By.CssSelector("div.mud-list-item"));

                foreach (var element in listItemElements)
                {
                    if (element.Text == value)
                    {
                        element.Click();
                        return;
                    }
                }
                Thread.Sleep(100);
            }

            throw new InvalidOperationException($"The Value {value} could not found");
        }

        private string FindText()
        {
            var element = Element.FindElement(By.TagName("input"));
            if (element.GetAttribute("type") == "hidden")
            {
                return element.FindNextElement(By.CssSelector("div")).Text;
            }

            return element.GetAttribute("value");
        }
    }
}
