using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;

namespace SeleniumTest;

[SetUpFixture]
public class WebDriverManager
{
    public static string Domain = "https://codeerlowcodeseleniumtest2.azurewebsites.net";

    static WebDriverManager()
    {
        var path = typeof(DataManager).Assembly.Location;
        for (int i = 0; i < 4; i++) path = Path.GetDirectoryName(path);
        Domain = File.ReadAllLines(Path.Combine(path!, "Config.txt"))[0];
    }


    static IWebDriver? _driver;
    public static IWebDriver Driver
    {
        get
        {
            if (_driver != null) return _driver;

            _driver = CreateDriver();
            _driver.Url = Domain;
            return _driver;
        }
    }

    public static void WaitLoading()
    {
        //表示されるまでタイムラグの考慮 Sleepは良くないけど他に手がない
        Thread.Sleep(500);

        // TODO NunitのTimeOutが非推奨になったんやったらどうしようかな
        // てかこれあれちゃうんか、ライブラリに取り込むべきか
        // loading が消えるまで待つ
        while (_driver!.FindElements(By.ClassName("backdrop")).Count == 1)
        {
            Thread.Sleep(50);
        }
    }

    public static void FailedCleanup()
    {
        if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed) return;
        _driver?.Dispose();
        _driver = null;
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        _driver?.Dispose();
        _driver = null;
        Process.GetProcessesByName("chromedriver").ToList().ForEach(e => e.Kill());
    }

    static IWebDriver CreateDriver()
    {
        Process.GetProcessesByName("chromedriver").ToList().ForEach(e => e.Kill());
        return new ChromeDriver();
    }
}
