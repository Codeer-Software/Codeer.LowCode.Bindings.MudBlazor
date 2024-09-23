using OpenQA.Selenium;
using SeleniumTest.PageObject;

namespace SeleniumTest.Scenario.DisplayText;

public class SearchFieldDisplayText
{
    IWebDriver _driver = default!;

    [SetUp]
    public void SetUp()
    {
        _driver = WebDriverManager.Driver;
        _driver.Url = WebDriverManager.Domain + "/Main/DisplayText";
    }

    [TearDown]
    public void TearDown()
        => WebDriverManager.FailedCleanup();

    [Test]
    public void CheckBoxのDisplayText()
    {
        var displayTextListPage = _driver.AttachDisplayTextListPage();
        displayTextListPage.Search.Fields.CheckLabel.Label.Text.Is("チェック");
    }

    [Test]
    public void ToggleのDisplayText()
    {
        var displayTextListPage = _driver.AttachDisplayTextListPage();
        displayTextListPage.Search.Fields.ToggleLabel.Label.Text.Is("トグル");
    }

    [Test]
    public void SwitchのDisplayText()
    {
        var displayTextListPage = _driver.AttachDisplayTextListPage();
        displayTextListPage.Search.Fields.SwitchLabel.Label.Text.Is("スイッチ");
    }

    [Test]
    public void DateのDisplayText()
    {
        var displayTextListPage = _driver.AttachDisplayTextListPage();
        displayTextListPage.Search.Fields.DateLabel.Label.Text.Is("日付");
    }

    [Test]
    public void DateTimeのDisplayText()
    {
        var displayTextListPage = _driver.AttachDisplayTextListPage();
        displayTextListPage.Search.Fields.DateTimeLabel.Label.Text.Is("日時");
    }

    [Test]
    public void LinkのDisplayText()
    {
        var displayTextListPage = _driver.AttachDisplayTextListPage();
        displayTextListPage.Search.Fields.LinkLabel.Label.Text.Is("リンク");
    }

    [Test]
    public void NumberのDisplayText()
    {
        var displayTextListPage = _driver.AttachDisplayTextListPage();
        displayTextListPage.Search.Fields.NumberLabel.Label.Text.Is("数値");
    }

    [Test]
    public void RadioのDisplayText()
    {
        var displayTextListPage = _driver.AttachDisplayTextListPage();
        displayTextListPage.Search.Fields.RadioLabel.Label.Text.Is("Radio");
    }

    [Test]
    public void SelectのDisplayText()
    {
        var displayTextListPage = _driver.AttachDisplayTextListPage();
        displayTextListPage.Search.Fields.SelectLabel.Label.Text.Is("選択肢");
    }

    [Test]
    public void SelectLinkのDisplayText()
    {
        var displayTextListPage = _driver.AttachDisplayTextListPage();
        displayTextListPage.Search.Fields.SelectLinkLabel.Label.Text.Is("選択肢リンク");
    }

    [Test]
    public void TextのDisplayText()
    {
        var displayTextListPage = _driver.AttachDisplayTextListPage();
        displayTextListPage.Search.Fields.TextLabel.Label.Text.Is("テキスト");
    }

    [Test]
    public void TimeのDisplayText()
    {
        var displayTextListPage = _driver.AttachDisplayTextListPage();
        displayTextListPage.Search.Fields.TimeLabel.Label.Text.Is("時刻");
    }

    [Test]
    public void FileのDisplayText()
    {
        var displayTextListPage = _driver.AttachDisplayTextListPage();
        displayTextListPage.Search.Fields.FileLabel.Label.Text.Is("ファイル");
    }
}
