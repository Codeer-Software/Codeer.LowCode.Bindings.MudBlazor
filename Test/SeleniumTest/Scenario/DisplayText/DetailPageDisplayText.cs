using OpenQA.Selenium;
using SeleniumTest.PageObject;

namespace SeleniumTest.Scenario.DisplayText;

public class DetailPageDisplayText
{
    IWebDriver _driver = default!;

    [SetUp]
    public void SetUp()
    {
        _driver = WebDriverManager.Driver;
        _driver.Url = WebDriverManager.Domain + "/Main/DisplayText/15";
    }

    [TearDown]
    public void TearDown()
        => WebDriverManager.FailedCleanup();

    [Test]
    public void CheckBoxのDisplayText()
    {
        var displayTextDetailPage = _driver.AttachDisplayTextDetailPage();
        displayTextDetailPage.Detail.CheckLabel.Label.Text.Is("チェック");
    }

    [Test]
    public void ToggleのDisplayText()
    {
        var displayTextDetailPage = _driver.AttachDisplayTextDetailPage();
        displayTextDetailPage.Detail.ToggleLabel.Label.Text.Is("トグル");
    }

    [Test]
    public void SwitchのDisplayText()
    {
        var displayTextDetailPage = _driver.AttachDisplayTextDetailPage();
        displayTextDetailPage.Detail.SwitchLabel.Label.Text.Is("スイッチ");
    }

    [Test]
    public void DateのDisplayText()
    {
        var displayTextDetailPage = _driver.AttachDisplayTextDetailPage();
        displayTextDetailPage.Detail.DateLabel.Label.Text.Is("日付");
    }

    [Test]
    public void DateTimeのDisplayText()
    {
        var displayTextDetailPage = _driver.AttachDisplayTextDetailPage();
        displayTextDetailPage.Detail.DateTimeLabel.Label.Text.Is("日時");
    }

    [Test]
    public void LinkのDisplayText()
    {
        var displayTextDetailPage = _driver.AttachDisplayTextDetailPage();
        displayTextDetailPage.Detail.LinkLabel.Label.Text.Is("リンク");
    }

    [Test]
    public void NumberのDisplayText()
    {
        var displayTextDetailPage = _driver.AttachDisplayTextDetailPage();
        displayTextDetailPage.Detail.NumberLabel.Label.Text.Is("数値");
    }

    [Test]
    public void RadioのDisplayText()
    {
        var displayTextDetailPage = _driver.AttachDisplayTextDetailPage();
        displayTextDetailPage.Detail.RadioLabel.Label.Text.Is("Radio");
    }

    [Test]
    public void SelectのDisplayText()
    {
        var displayTextDetailPage = _driver.AttachDisplayTextDetailPage();
        displayTextDetailPage.Detail.SelectLabel.Label.Text.Is("選択肢");
    }

    [Test]
    public void SelectLinkのDisplayText()
    {
        var displayTextDetailPage = _driver.AttachDisplayTextDetailPage();
        displayTextDetailPage.Detail.SelectLinkLabel.Label.Text.Is("選択肢リンク");
    }

    [Test]
    public void TextのDisplayText()
    {
        var displayTextDetailPage = _driver.AttachDisplayTextDetailPage();
        displayTextDetailPage.Detail.TextLabel.Label.Text.Is("テキスト");
    }

    [Test]
    public void TimeのDisplayText()
    {
        var displayTextDetailPage = _driver.AttachDisplayTextDetailPage();
        displayTextDetailPage.Detail.TimeLabel.Label.Text.Is("時刻");
    }

    [Test]
    public void FileのDisplayText()
    {
        var displayTextDetailPage = _driver.AttachDisplayTextDetailPage();
        displayTextDetailPage.Detail.FileLabel.Label.Text.Is("ファイル");
    }
}
