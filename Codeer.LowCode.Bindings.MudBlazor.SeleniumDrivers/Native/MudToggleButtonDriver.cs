using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers.Native
{
    public class MudToggleButtonDriver(IWebElement element) : ControlDriverBase(element)
    {
        public bool Checked => Element.GetAttribute("aria-checked") == "true";

        public void Edit(bool b)
        {
            if (Checked == b) return;
            Element.Click();
        }
    }
}
