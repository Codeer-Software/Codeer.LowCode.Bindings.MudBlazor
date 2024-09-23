using OpenQA.Selenium;
using SeleniumTest.PageObject;

namespace SeleniumTest.Scenario;

public class 通常Field検索Test
{
    IWebDriver _driver = default!;

    [SetUp]
    public void SetUp()
    {
        _driver = WebDriverManager.Driver;
        _driver.Url = WebDriverManager.Domain + "/Main/ReadDataControls";
    }

    [TearDown]
    public void TearDown()
        => WebDriverManager.FailedCleanup();

    [Test]
    public void CheckBoxの検索()
    {
        var readDataControlsListPage = _driver.AttachReadDataControlsListPage();

        //true検索
        readDataControlsListPage.Search.Fields.Check.Select.Edit("true");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Check.ReadOnlyText.Text.Is("True");

        //false検索
        readDataControlsListPage.Search.Fields.Check.Select.Edit("false");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Check.ReadOnlyText.Text.Is("False");

        //空にした場合は条件はクリアされる URLのパラメータも消える
        readDataControlsListPage.Search.Fields.Check.Select.Edit("");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(16);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadDataControls");
    }

    [Test]
    public void Toggleの検索()
    {
        var readDataControlsListPage = _driver.AttachReadDataControlsListPage();
        //true検索
        readDataControlsListPage.Search.Fields.Toggle.Select.Edit("true");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Toggle.ReadOnlyText.Text.Is("True");
        //false検索
        readDataControlsListPage.Search.Fields.Toggle.Select.Edit("false");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Toggle.ReadOnlyText.Text.Is("False");
        //空にした場合は条件はクリアされる URLのパラメータも消える
        readDataControlsListPage.Search.Fields.Toggle.Select.Edit("");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(16);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadDataControls");
    }

    [Test]
    public void Switchの検索()
    {
        var readDataControlsListPage = _driver.AttachReadDataControlsListPage();
        //true検索
        readDataControlsListPage.Search.Fields.Switch.Select.Edit("true");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Switch.ReadOnlyText.Text.Is("True");
        //false検索
        readDataControlsListPage.Search.Fields.Switch.Select.Edit("false");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Switch.ReadOnlyText.Text.Is("False");
        //空にした場合は条件はクリアされる URLのパラメータも消える
        readDataControlsListPage.Search.Fields.Switch.Select.Edit("");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(16);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadDataControls");
    }

    [Test]
    public void Dateの検索()
    {
        var readDataControlsListPage = _driver.AttachReadDataControlsListPage();

        //開始日検索
        readDataControlsListPage.Search.Fields.Date.StartDate.Edit(2024, 05, 06);
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(0);

        readDataControlsListPage.Search.Fields.Date.StartDate.Edit(2024, 05, 05);
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Date.ReadOnlyText.Text.Is("2024/05/05");

        readDataControlsListPage.Search.Fields.Date.StartDate.Element.SendKeys(Keys.Delete);

        //終了日検索
        readDataControlsListPage.Search.Fields.Date.EndDate.Edit(2024, 05, 04);
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(0);

        readDataControlsListPage.Search.Fields.Date.EndDate.Edit(2024, 05, 05);
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Date.ReadOnlyText.Text.Is("2024/05/05");

        //開始と終了
        readDataControlsListPage.Search.Fields.Date.StartDate.Edit(2024, 05, 05);
        readDataControlsListPage.Search.Fields.Date.StartDate.Edit(2024, 05, 05);
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Date.ReadOnlyText.Text.Is("2024/05/05");

        //空にした場合は条件はクリアされる URLのパラメータも消える
        readDataControlsListPage.Search.Fields.Date.StartDate.Element.SendKeys(Keys.Delete);
        readDataControlsListPage.Search.Fields.Date.EndDate.Element.SendKeys(Keys.Delete);
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(16);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadDataControls");
    }

    [Test]
    public void DateTimeの検索()
    {
        var readDataControlsListPage = _driver.AttachReadDataControlsListPage();

        //開始日検索 見つからないケース
        readDataControlsListPage.Search.Fields.DateTime.StartDate.Edit(2024, 05, 07, 01, 14);
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(0);

        // 見つかるケース
        readDataControlsListPage.Search.Fields.DateTime.StartDate.Edit(2024, 05, 05, 01, 14);
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).DateTime.ReadOnlyText.Text.Is("2024/05/06 13:00:00");

        readDataControlsListPage.Search.Fields.DateTime.StartDate.Element.SendKeys(Keys.Delete);

        //終了日検索  見つからないケース
        readDataControlsListPage.Search.Fields.DateTime.EndDate.Edit(2024, 05, 05, 01, 14);
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(0);

        // 見つかるケース
        readDataControlsListPage.Search.Fields.DateTime.EndDate.Edit(2024, 05, 07, 01, 14);
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).DateTime.ReadOnlyText.Text.Is("2024/05/06 13:00:00");

        //開始と終了
        readDataControlsListPage.Search.Fields.DateTime.StartDate.Edit(2024, 05, 05, 01, 14);
        readDataControlsListPage.Search.Fields.DateTime.StartDate.Edit(2024, 05, 07, 01, 14);
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).DateTime.ReadOnlyText.Text.Is("2024/05/06 13:00:00");

        //空にした場合は条件はクリアされる URLのパラメータも消える
        readDataControlsListPage.Search.Fields.DateTime.StartDate.Element.SendKeys(Keys.Delete);
        readDataControlsListPage.Search.Fields.DateTime.EndDate.Element.SendKeys(Keys.Delete);
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(16);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadDataControls");
    }

    [Test]
    public void Linkの検索()
    {
        var readDataControlsListPage = _driver.AttachReadDataControlsListPage();
        readDataControlsListPage.Search.Fields.Link.Search.Click();
        readDataControlsListPage.Search.Fields.Link.LinkList.Items.GetItem(1).Code.ReadOnlyText.Click();
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Link.ReadOnlyText.Text.Is("BBB");

        //空にした場合は条件はクリアされる URLのパラメータも消える
        readDataControlsListPage.Search.Fields.Link.Clear.Click();
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(16);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadDataControls");
    }

    [Test]
    public void Numberの検索()
    {
        var readDataControlsListPage = _driver.AttachReadDataControlsListPage();

        //min検索 みつからない
        readDataControlsListPage.Search.Fields.Number.Min.Edit("124");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(0);

        //min検索 みつかる
        readDataControlsListPage.Search.Fields.Number.Min.Edit("123");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Number.ReadOnlyText.Text.Is("123");

        readDataControlsListPage.Search.Clear.Click();

        //max検索 みつからない
        readDataControlsListPage.Search.Fields.Number.Max.Edit("122");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(0);

        //max検索 みつかる
        readDataControlsListPage.Search.Fields.Number.Max.Edit("123");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Number.ReadOnlyText.Text.Is("123");

        // min max 検索
        readDataControlsListPage.Search.Fields.Number.Min.Edit("123");
        readDataControlsListPage.Search.Fields.Number.Max.Edit("123");
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Number.ReadOnlyText.Text.Is("123");

        // 数値は空欄にできない
    }

    [Test]
    public void Radioの検索()
    {
        var readDataControlsListPage = _driver.AttachReadDataControlsListPage();
        readDataControlsListPage.Search.Fields.RadioGroup.Select.Edit("B");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).RadioGroup.Value.Text.Is("B");


        //空にした場合は条件はクリアされる URLのパラメータも消える
        readDataControlsListPage.Search.Fields.RadioGroup.Select.Edit("");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(16);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadDataControls");


        // NOT 検索
        readDataControlsListPage.Search.Fields.RadioGroup.IsNot.Edit(true);
        readDataControlsListPage.Search.Fields.RadioGroup.Select.Edit("B");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(14);
        readDataControlsListPage.List.Items.GetItem(0).RadioGroup.Value.Text.Is(string.Empty);
    }

    [Test]
    public void Selectの検索()
    {
        var readDataControlsListPage = _driver.AttachReadDataControlsListPage();
        readDataControlsListPage.Search.Fields.Select.Select.Edit("B");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Select.ReadOnlyText.Text.Is("B");

        //空にした場合は条件はクリアされる URLのパラメータも消える
        readDataControlsListPage.Search.Fields.Select.Select.Edit("");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(16);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadDataControls");


        // 'NOT' 検索
        readDataControlsListPage.Search.Fields.Select.IsNot.Edit(true);
        readDataControlsListPage.Search.Fields.Select.Select.Edit("B");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(14);
        readDataControlsListPage.List.Items.GetItem(0).Select.ReadOnlyText.Text.Is(string.Empty);
    }

    [Test]
    public void SelectLinkの検索()
    {
        var readDataControlsListPage = _driver.AttachReadDataControlsListPage();
        readDataControlsListPage.Search.Fields.SelectLink.Select.Edit("CCC");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).SelectLink.ReadOnlyText.Text.Is("CCC");

        //空にした場合は条件はクリアされる URLのパラメータも消える
        readDataControlsListPage.Search.Fields.SelectLink.Select.Edit("");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(16);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadDataControls");


        // 'NOT' 検索
        readDataControlsListPage.Search.Fields.SelectLink.IsNot.Edit(true);
        readDataControlsListPage.Search.Fields.SelectLink.Select.Edit("CCC");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(14);
        readDataControlsListPage.List.Items.GetItem(0).SelectLink.ReadOnlyText.Text.Is(string.Empty);
    }

    [Test]
    public void Textの検索()
    {
        // Equal 検索
        var readDataControlsListPage = _driver.AttachReadDataControlsListPage();
        readDataControlsListPage.Search.Fields.Text.Text.Edit("abc");
        readDataControlsListPage.Search.Fields.Text.Match.Edit("Equal");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Text.ReadOnlyText.Text.Is("abc");

        readDataControlsListPage.Search.Clear.Click();

        // Like 検索
        readDataControlsListPage.Search.Fields.Text.Text.Edit("b");
        readDataControlsListPage.Search.Fields.Text.Match.Edit("Like");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Text.ReadOnlyText.Text.Is("abc");


        //空にした場合は条件はクリアされる URLのパラメータも消える
        readDataControlsListPage.Search.Fields.Text.Text.Edit("");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(16);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadDataControls");
    }


    [Test]
    public void Timeの検索()
    {
        var readDataControlsListPage = _driver.AttachReadDataControlsListPage();

        //開始時刻 検索 みつからない
        readDataControlsListPage.Search.Fields.Time.StartTime.Edit(19, 06);
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(0);

        //開始時刻 検索 みつからる
        readDataControlsListPage.Search.Fields.Time.StartTime.Edit(19, 00);
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Time.ReadOnlyText.Text.Is("19:00:00");

        readDataControlsListPage.Search.Fields.Time.StartTime.Element.SendKeys(Keys.Delete);

        //終了時刻 検索 みつからない
        readDataControlsListPage.Search.Fields.Time.EndTime.Edit(18, 59);
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(0);

        //終了時刻 検索 みつからる
        readDataControlsListPage.Search.Fields.Time.EndTime.Edit(19, 00);
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Time.ReadOnlyText.Text.Is("19:00:00");

        //開始と終了
        readDataControlsListPage.Search.Fields.Time.StartTime.Edit(19, 00);
        readDataControlsListPage.Search.Fields.Time.EndTime.Edit(19, 00);
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).Time.ReadOnlyText.Text.Is("19:00:00");

        //空にした場合は条件はクリアされる URLのパラメータも消える
        readDataControlsListPage.Search.Fields.Time.StartTime.Element.SendKeys(Keys.Delete);
        readDataControlsListPage.Search.Fields.Time.EndTime.Element.SendKeys(Keys.Delete);
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(16);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadDataControls");
    }

    [Test]
    public void Fileの検索()
    {
        var readDataControlsListPage = _driver.AttachReadDataControlsListPage();
        // File名 Equals 検索
        readDataControlsListPage.Search.Fields.File.FileName.Edit("data.txt");
        readDataControlsListPage.Search.Fields.File.FileNameMatch.Edit("Equal");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).File.ReadOnlyText.Text.Is("data.txt");

        // File名 Like 検索
        readDataControlsListPage.Search.Fields.File.FileName.Edit("ata");
        readDataControlsListPage.Search.Fields.File.FileNameMatch.Edit("Like");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).File.ReadOnlyText.Text.Is("data.txt");

        readDataControlsListPage.Search.Clear.Click();

        // File サイズ 検索
        readDataControlsListPage.Search.Fields.File.MinFileSize.Edit("10");
        readDataControlsListPage.Search.Fields.File.MaxFileSize.Edit("11");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.GetItem(0).File.ReadOnlyText.Text.Is("data.txt");

        readDataControlsListPage.Search.Fields.File.MinFileSize.Edit("11");
        readDataControlsListPage.Search.Fields.File.MaxFileSize.Edit("12");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(0);

        readDataControlsListPage.Search.Fields.File.MinFileSize.Edit("");
        readDataControlsListPage.Search.Fields.File.MaxFileSize.Edit("");
        readDataControlsListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDataControlsListPage.List.Items.Count.Is(16);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadDataControls");
    }
}
