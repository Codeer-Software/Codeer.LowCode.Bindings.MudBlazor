using OpenQA.Selenium;
using SeleniumTest.PageObject;

namespace SeleniumTest.Scenario;

public class 通常Field書き込みTest
{
    IWebDriver _driver = default!;

    [SetUp]
    public void SetUp()
    {
        DataManager.DeleteWriteDataControls();
        _driver = WebDriverManager.Driver;
        _driver.Url = WebDriverManager.Domain + "/Main/WriteDataControls";
    }

    [TearDown]
    public void TearDown()
    {
        WebDriverManager.FailedCleanup();
        DataManager.DeleteWriteDataControls();
    }

    [Test]
    public void CheckBox()
    {
        var writeDataControlsListPage = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();

        //新規作成
        writeDataControlsListPage.List.Create.Click();
        WebDriverManager.WaitLoading();
        var writeDataControlsDetailPage = _driver.AttachWriteDataControlsDetailPage();
        writeDataControlsDetailPage.Detail.Check.Edit(true);
        writeDataControlsDetailPage.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Check.Checked.Is(true);

        //確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        WebDriverManager.WaitLoading();
        var writeDataControlsListPage1 = _driver.AttachWriteDataControlsListPage();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage1.List.Items.GetItem(0).Check.ReadOnlyText.Is("True");
        writeDataControlsListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeDataControlsDetailPage2 = _driver.AttachWriteDataControlsDetailPage();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage2.Detail.Check.Edit(false);
        writeDataControlsDetailPage2.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Check.Checked.Is(false);

        //確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        var writeDataControlsListPage2 = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage2.List.Items.GetItem(0).Check.ReadOnlyText.Is("False");
    }

    [Test]
    public void Toggle()
    {
        var writeDataControlsListPage = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();

        //新規作成
        writeDataControlsListPage.List.Create.Click();
        WebDriverManager.WaitLoading();

        var writeDataControlsDetailPage = _driver.AttachWriteDataControlsDetailPage();
        writeDataControlsDetailPage.Detail.Toggle.Edit(true);
        writeDataControlsDetailPage.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Toggle.Checked.Is(true);

        //一覧での表示確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        WebDriverManager.WaitLoading();
        var writeDataControlsListPage1 = _driver.AttachWriteDataControlsListPage();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage1.List.Items.GetItem(0).Toggle.ReadOnlyText.Is("True");
        writeDataControlsListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeDataControlsDetailPage2 = _driver.AttachWriteDataControlsDetailPage();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage2.Detail.Toggle.Edit(false);
        writeDataControlsDetailPage2.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Toggle.Checked.Is(false);

        //確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        var writeDataControlsListPage2 = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage2.List.Items.GetItem(0).Toggle.ReadOnlyText.Is("False");
    }

    [Test]
    public void Switch()
    {
        var writeDataControlsListPage = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();

        //新規作成
        writeDataControlsListPage.List.Create.Click();
        WebDriverManager.WaitLoading();

        var writeDataControlsDetailPage = _driver.AttachWriteDataControlsDetailPage();
        writeDataControlsDetailPage.Detail.Switch.Edit(true);
        writeDataControlsDetailPage.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Switch.Checked.Is(true);

        //一覧での表示確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        WebDriverManager.WaitLoading();
        var writeDataControlsListPage1 = _driver.AttachWriteDataControlsListPage();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage1.List.Items.GetItem(0).Switch.ReadOnlyText.Is("True");
        writeDataControlsListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeDataControlsDetailPage2 = _driver.AttachWriteDataControlsDetailPage();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage2.Detail.Switch.Edit(false);
        writeDataControlsDetailPage2.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Switch.Checked.Is(false);

        //一覧表示で確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        var writeDataControlsListPage2 = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage2.List.Items.GetItem(0).Switch.ReadOnlyText.Is("False");
    }

    [Test]
    public void Date()
    {
        var writeDataControlsListPage = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();

        //新規作成
        writeDataControlsListPage.List.Create.Click();
        WebDriverManager.WaitLoading();

        var writeDataControlsDetailPage = _driver.AttachWriteDataControlsDetailPage();
        writeDataControlsDetailPage.Detail.Date.Input.Element.Click();
        writeDataControlsDetailPage.Detail.Date.Input.Edit(2024, 9, 15);
        writeDataControlsDetailPage.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Date.Input.Text.Is("2024-09-15");

        //一覧での表示確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        WebDriverManager.WaitLoading();
        var writeDataControlsListPage1 = _driver.AttachWriteDataControlsListPage();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage1.List.Items.GetItem(0).Date.ReadOnlyText.Text.Is("2024/09/15");
        writeDataControlsListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeDataControlsDetailPage2 = _driver.AttachWriteDataControlsDetailPage();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Date.Input.Edit(2024, 12, 31);
        writeDataControlsDetailPage2.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Date.Input.Text.Is("2024-12-31");

        //一覧表示で確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        var writeDataControlsListPage2 = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage2.List.Items.GetItem(0).Date.ReadOnlyText.Text.Is("2024/12/31");
    }


    [Test]
    public void DateTime()
    {
        var writeDataControlsListPage = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();

        //新規作成
        writeDataControlsListPage.List.Create.Click();
        WebDriverManager.WaitLoading();

        var writeDataControlsDetailPage = _driver.AttachWriteDataControlsDetailPage();
        writeDataControlsDetailPage.Detail.DateTime.Input.Element.Click();
        writeDataControlsDetailPage.Detail.DateTime.Input.Edit(2024, 9, 15, 10, 34);
        writeDataControlsDetailPage.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.DateTime.Input.Text.Is("2024-09-15T10:34");

        //一覧での表示確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        WebDriverManager.WaitLoading();
        var writeDataControlsListPage1 = _driver.AttachWriteDataControlsListPage();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage1.List.Items.GetItem(0).DateTime.ReadOnlyText.Text.Is("2024/09/15 10:34:00");
        writeDataControlsListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeDataControlsDetailPage2 = _driver.AttachWriteDataControlsDetailPage();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.DateTime.Input.Edit(2024, 12, 31, 11, 56);
        writeDataControlsDetailPage2.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.DateTime.Input.Text.Is("2024-12-31T11:56");

        //一覧表示で確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        var writeDataControlsListPage2 = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage2.List.Items.GetItem(0).DateTime.ReadOnlyText.Text.Is("2024/12/31 11:56:00");
    }

    [Test]
    public void Link()
    {
        var writeDataControlsListPage = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();

        //新規作成
        writeDataControlsListPage.List.Create.Click();
        WebDriverManager.WaitLoading();

        var writeDataControlsDetailPage = _driver.AttachWriteDataControlsDetailPage();
        writeDataControlsDetailPage.Detail.Link.Search.Click();
        writeDataControlsDetailPage.Detail.Link.LinkList.Items.GetItem(1).Element.Click();
        writeDataControlsDetailPage.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Link.Input.Text.Is("BBB");

        //一覧での表示確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        WebDriverManager.WaitLoading();
        var writeDataControlsListPage1 = _driver.AttachWriteDataControlsListPage();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage1.List.Items.GetItem(0).Link.ReadOnlyText.Text.Is("BBB");
        writeDataControlsListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeDataControlsDetailPage2 = _driver.AttachWriteDataControlsDetailPage();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage2.Detail.Link.Search.Click();
        writeDataControlsDetailPage2.Detail.Link.LinkList.Items.GetItem(0).Element.Click();
        writeDataControlsDetailPage2.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage2.Detail.Link.Input.Text.Is("CCC");

        //一覧表示で確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        var writeDataControlsListPage2 = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();
        writeDataControlsListPage2.List.Items.Count.Is(1);
        writeDataControlsListPage2.List.Items.GetItem(0).Link.ReadOnlyText.Text.Is("CCC");
    }

    [Test]
    public void Number()
    {
        var writeDataControlsListPage = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();

        //新規作成
        writeDataControlsListPage.List.Create.Click();
        WebDriverManager.WaitLoading();

        var writeDataControlsDetailPage = _driver.AttachWriteDataControlsDetailPage();
        writeDataControlsDetailPage.Detail.Number.Input.Edit("834");
        writeDataControlsDetailPage.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Number.Input.Text.Is("834");

        //一覧での表示確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        WebDriverManager.WaitLoading();
        var writeDataControlsListPage1 = _driver.AttachWriteDataControlsListPage();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage1.List.Items.GetItem(0).Number.ReadOnlyText.Text.Is("834");
        writeDataControlsListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeDataControlsDetailPage2 = _driver.AttachWriteDataControlsDetailPage();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage2.Detail.Number.Input.Edit("512");
        writeDataControlsDetailPage2.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage2.Detail.Number.Input.Text.Is("512");

        //一覧表示で確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        var writeDataControlsListPage2 = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();
        writeDataControlsListPage2.List.Items.Count.Is(1);
        writeDataControlsListPage2.List.Items.GetItem(0).Number.ReadOnlyText.Text.Is("512");
    }

    [Test]
    public void Radio()
    {
        var writeDataControlsListPage = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();

        //新規作成
        writeDataControlsListPage.List.Create.Click();
        WebDriverManager.WaitLoading();

        var writeDataControlsDetailPage = _driver.AttachWriteDataControlsDetailPage();
        writeDataControlsDetailPage.Detail.RadioA.Label.Click();
        writeDataControlsDetailPage.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.RadioA.Input.Checked.IsTrue();

        //一覧での表示確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        WebDriverManager.WaitLoading();
        var writeDataControlsListPage1 = _driver.AttachWriteDataControlsListPage();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage1.List.Items.GetItem(0).RadioGroup.Value.Text.Is("A");
        writeDataControlsListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeDataControlsDetailPage2 = _driver.AttachWriteDataControlsDetailPage();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage2.Detail.RadioC.Label.Click();
        writeDataControlsDetailPage2.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage2.Detail.RadioA.Input.Checked.IsFalse();
        writeDataControlsDetailPage2.Detail.RadioB.Input.Checked.IsFalse();
        writeDataControlsDetailPage2.Detail.RadioC.Input.Checked.IsTrue();

        //一覧表示で確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        var writeDataControlsListPage2 = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();
        writeDataControlsListPage2.List.Items.Count.Is(1);
        writeDataControlsListPage2.List.Items.GetItem(0).RadioGroup.Value.Text.Is("C");
    }

    [Test]
    public void Select()
    {
        var writeDataControlsListPage = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();

        //新規作成
        writeDataControlsListPage.List.Create.Click();
        WebDriverManager.WaitLoading();

        var writeDataControlsDetailPage = _driver.AttachWriteDataControlsDetailPage();
        writeDataControlsDetailPage.Detail.Select.Select.Edit("A");
        writeDataControlsDetailPage.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Select.Select.Text.Is("A");

        //一覧での表示確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        WebDriverManager.WaitLoading();
        var writeDataControlsListPage1 = _driver.AttachWriteDataControlsListPage();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage1.List.Items.GetItem(0).Select.ReadOnlyText.Text.Is("A");
        writeDataControlsListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeDataControlsDetailPage2 = _driver.AttachWriteDataControlsDetailPage();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage2.Detail.Select.Select.Edit("B");
        writeDataControlsDetailPage2.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage2.Detail.Select.Select.Text.Is("B");

        //一覧表示で確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        var writeDataControlsListPage2 = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();
        writeDataControlsListPage2.List.Items.Count.Is(1);
        writeDataControlsListPage2.List.Items.GetItem(0).Select.ReadOnlyText.Text.Is("B");
    }

    [Test]
    public void SelectLink()
    {
        var writeDataControlsListPage = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();

        //新規作成
        writeDataControlsListPage.List.Create.Click();
        WebDriverManager.WaitLoading();

        var writeDataControlsDetailPage = _driver.AttachWriteDataControlsDetailPage();
        writeDataControlsDetailPage.Detail.SelectLink.Element.Click();
        writeDataControlsDetailPage.Detail.SelectLink.Select.Edit("AAA");
        writeDataControlsDetailPage.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.SelectLink.Select.Text.Is("AAA");

        //一覧での表示確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        WebDriverManager.WaitLoading();
        var writeDataControlsListPage1 = _driver.AttachWriteDataControlsListPage();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage1.List.Items.GetItem(0).SelectLink.ReadOnlyText.Text.Is("AAA");
        writeDataControlsListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeDataControlsDetailPage2 = _driver.AttachWriteDataControlsDetailPage();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.SelectLink.Element.Click();
        writeDataControlsDetailPage2.Detail.SelectLink.Select.Edit("BBB");
        writeDataControlsDetailPage2.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage2.Detail.SelectLink.Select.Text.Is("BBB");

        //一覧表示で確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        var writeDataControlsListPage2 = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();
        writeDataControlsListPage2.List.Items.Count.Is(1);
        writeDataControlsListPage2.List.Items.GetItem(0).SelectLink.ReadOnlyText.Text.Is("BBB");
    }

    [Test]
    public void Text()
    {
        var writeDataControlsListPage = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();

        //新規作成
        writeDataControlsListPage.List.Create.Click();
        WebDriverManager.WaitLoading();

        var writeDataControlsDetailPage = _driver.AttachWriteDataControlsDetailPage();
        writeDataControlsDetailPage.Detail.Text.Input.Edit("fifty-fifty");
        writeDataControlsDetailPage.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Text.Input.Text.Is("fifty-fifty");

        //一覧での表示確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        WebDriverManager.WaitLoading();
        var writeDataControlsListPage1 = _driver.AttachWriteDataControlsListPage();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage1.List.Items.GetItem(0).Text.ReadOnlyText.Text.Is("fifty-fifty");
        writeDataControlsListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeDataControlsDetailPage2 = _driver.AttachWriteDataControlsDetailPage();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage2.Detail.Text.Input.Edit("triple-double");
        writeDataControlsDetailPage2.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage2.Detail.Text.Input.Text.Is("triple-double");

        //一覧表示で確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        var writeDataControlsListPage2 = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();
        writeDataControlsListPage2.List.Items.Count.Is(1);
        writeDataControlsListPage2.List.Items.GetItem(0).Text.ReadOnlyText.Text.Is("triple-double");
    }

    [Test]
    public void Time()
    {
        var writeDataControlsListPage = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();

        //新規作成
        writeDataControlsListPage.List.Create.Click();
        WebDriverManager.WaitLoading();

        var writeDataControlsDetailPage = _driver.AttachWriteDataControlsDetailPage();
        writeDataControlsDetailPage.Detail.Time.Input.Edit(10, 34);
        writeDataControlsDetailPage.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Time.Input.Text.Is("10:34");

        //一覧での表示確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        WebDriverManager.WaitLoading();
        var writeDataControlsListPage1 = _driver.AttachWriteDataControlsListPage();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage1.List.Items.GetItem(0).Time.ReadOnlyText.Text.Is("10:34:00");
        writeDataControlsListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeDataControlsDetailPage2 = _driver.AttachWriteDataControlsDetailPage();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Time.Input.Edit(11, 23);
        writeDataControlsDetailPage2.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Time.Input.Text.Is("11:23");

        //一覧表示で確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        var writeDataControlsListPage2 = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();
        writeDataControlsListPage2.List.Items.Count.Is(1);
        writeDataControlsListPage2.List.Items.GetItem(0).Time.ReadOnlyText.Text.Is("11:23:00");
    }

    [Test]
    public void File()
    {
        var writeDataControlsListPage = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();

        //新規作成
        writeDataControlsListPage.List.Create.Click();
        WebDriverManager.WaitLoading();

        var writeDataControlsDetailPage = _driver.AttachWriteDataControlsDetailPage();
        var filePath = Path.Combine(Path.GetDirectoryName(GetType().Assembly.Location)!, @"Scenario\TestData\地図.pdf");
        writeDataControlsDetailPage.Detail.File.Upload(filePath);
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.File.Element.Text.Is("地図.pdf");

        //一覧での表示確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        WebDriverManager.WaitLoading();
        var writeDataControlsListPage1 = _driver.AttachWriteDataControlsListPage();
        writeDataControlsListPage1.List.Items.Count.Is(1);
        writeDataControlsListPage1.List.Items.GetItem(0).File.ReadOnlyText.Text.Is("地図.pdf");
        writeDataControlsListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //削除
        var writeDataControlsDetailPage2 = _driver.AttachWriteDataControlsDetailPage();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage2.Detail.File.Delete.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage.Detail.Submit.Submit.Click();
        WebDriverManager.WaitLoading();
        writeDataControlsDetailPage2.Detail.File.Element.Text.Is(string.Empty);

        //一覧表示で確認
        _driver.AttachMainLeft().WriteDataControls.Click();
        var writeDataControlsListPage2 = _driver.AttachWriteDataControlsListPage();
        WebDriverManager.WaitLoading();
        writeDataControlsListPage2.List.Items.Count.Is(1);
        writeDataControlsListPage2.List.Items.GetItem(0).File.ReadOnlyText.Text.Is(string.Empty);
    }
}
