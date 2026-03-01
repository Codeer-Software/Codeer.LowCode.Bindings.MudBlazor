using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumTest
{
    static internal class Helper
    {
        public static bool IsControlViewOnly(this IWebElement element)
            => element.GetCssValue("pointer-events") == "none";

        public static void DoubleClick(this IWebElement element)
        {
            if (element is null) throw new ArgumentNullException(nameof(element));
            // IWebElement -> IWebDriver を“無理くり”取る
            var driver = (element as IWrapsDriver)?.WrappedDriver;
            if (driver is IJavaScriptExecutor js)
            {
                js.ExecuteScript(
                    "arguments[0].scrollIntoView({block:'center', inline:'center'});",
                    element);
            }
            new Actions(driver)
                .MoveToElement(element)
                .DoubleClick(element)
                .Perform();
        }
    }
}
