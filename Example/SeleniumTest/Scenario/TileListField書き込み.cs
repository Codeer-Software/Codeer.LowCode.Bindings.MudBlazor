using OpenQA.Selenium;
using SeleniumTest.PageObject;

namespace SeleniumTest.Scenario;

public class TileListField書き込み
{
    IWebDriver _driver = default!;

    [SetUp]
    public void SetUp()
    {
        DataManager.DeleteWriteTileListDataControls();
        _driver = WebDriverManager.Driver;
        _driver.Url = WebDriverManager.Domain + "/Main/WriteTileListData";
    }

    [TearDown]
    public void TearDown()
        => WebDriverManager.FailedCleanup();

    [Test]
    public void CheckBox()
    {
        var writeListDataListPage = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage.List.Create.Click();

        //作成
        var writeListDataDetailPage = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.Name.Input.Edit("A");
        writeListDataDetailPage.Detail.List.Create.Click();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Check.Edit(true);
        writeListDataDetailPage.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Check.Checked.Is(true);

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        WebDriverManager.WaitLoading();
        var writeListDataListPage1 = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage1.List.Items.Count.Is(1);
        writeListDataListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeListDataDetailPage2 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Check.Checked.Is(true);
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Check.Edit(false);
        writeListDataDetailPage2.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Check.Checked.Is(false);

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        var writeListDataListPage2 = _driver.AttachWriteTileListDataListPage();
        WebDriverManager.WaitLoading();
        writeListDataListPage1.List.Items.Count.Is(1);
        writeListDataListPage2.List.Items.GetItem(0).NavigateToDetail.Click();

        //最後の編集を確認
        var writeListDataDetailPage3 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage3.Detail.List.Items.GetItem(0).Check.Checked.Is(false);
    }


    [Test]
    public void Toggle()
    {
        var writeListDataListPage = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage.List.Create.Click();

        //作成
        var writeListDataDetailPage = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.Name.Input.Edit("Toggle編集");
        writeListDataDetailPage.Detail.List.Create.Click();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Toggle.Edit(true);
        writeListDataDetailPage.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Toggle.Checked.Is(true);

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        WebDriverManager.WaitLoading();
        var writeListDataListPage1 = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage1.List.Items.Count.Is(1);
        writeListDataListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeListDataDetailPage2 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Toggle.Checked.Is(true);
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Toggle.Edit(false);
        writeListDataDetailPage2.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Toggle.Checked.Is(false);

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        var writeListDataListPage2 = _driver.AttachWriteTileListDataListPage();
        WebDriverManager.WaitLoading();
        writeListDataListPage1.List.Items.Count.Is(1);
        writeListDataListPage2.List.Items.GetItem(0).NavigateToDetail.Click();

        //最後の編集を確認
        var writeListDataDetailPage3 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage3.Detail.List.Items.GetItem(0).Toggle.Checked.Is(false);
    }

    [Test]
    public void Switch()
    {
        var writeListDataListPage = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage.List.Create.Click();

        //作成
        var writeListDataDetailPage = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.Name.Input.Edit("Switch編集");
        writeListDataDetailPage.Detail.List.Create.Click();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Switch.Edit(true);
        writeListDataDetailPage.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Switch.Checked.Is(true);

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        WebDriverManager.WaitLoading();
        var writeListDataListPage1 = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage1.List.Items.Count.Is(1);
        writeListDataListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeListDataDetailPage2 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Switch.Checked.Is(true);
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Switch.Edit(false);
        writeListDataDetailPage2.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Switch.Checked.Is(false);

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        var writeListDataListPage2 = _driver.AttachWriteTileListDataListPage();
        WebDriverManager.WaitLoading();
        writeListDataListPage2.List.Items.Count.Is(1);
        writeListDataListPage2.List.Items.GetItem(0).NavigateToDetail.Click();

        //最後の編集を確認
        var writeListDataDetailPage3 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage3.Detail.List.Items.GetItem(0).Switch.Checked.Is(false);
    }

    [Test]
    public void Date()
    {
        var writeListDataListPage = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage.List.Create.Click();

        //作成
        var writeListDataDetailPage = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.Name.Input.Edit("Date編集");
        writeListDataDetailPage.Detail.List.Create.Click();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Date.Input.Edit(2024, 9, 11);
        writeListDataDetailPage.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Date.Input.Text.Is("2024-09-11");

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        WebDriverManager.WaitLoading();
        var writeListDataListPage1 = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage1.List.Items.Count.Is(1);
        writeListDataListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeListDataDetailPage2 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Date.Input.Text.Is("2024-09-11");
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Date.Input.Edit(2024, 11, 13);
        writeListDataDetailPage2.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Date.Input.Text.Is("2024-11-13");

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        var writeListDataListPage2 = _driver.AttachWriteTileListDataListPage();
        WebDriverManager.WaitLoading();
        writeListDataListPage2.List.Items.Count.Is(1);
        writeListDataListPage2.List.Items.GetItem(0).NavigateToDetail.Click();

        //最後の編集を確認
        var writeListDataDetailPage3 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage3.Detail.List.Items.GetItem(0).Date.Input.Text.Is("2024-11-13");
    }

    [Test]
    public void DateTime()
    {
        var writeListDataListPage = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage.List.Create.Click();

        //作成
        var writeListDataDetailPage = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.Name.Input.Edit("DateTime編集");
        writeListDataDetailPage.Detail.List.Create.Click();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).DateTime.Input
            .Edit(2024, 9, 11, 7, 55);
        writeListDataDetailPage.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).DateTime.Input.Text.Is("2024-09-11T07:55");

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        WebDriverManager.WaitLoading();
        var writeListDataListPage1 = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage1.List.Items.Count.Is(1);
        writeListDataListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeListDataDetailPage2 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).DateTime.Input.Text.Is("2024-09-11T07:55");
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).DateTime.Input
            .Edit(2024, 12, 23, 8, 13);
        writeListDataDetailPage2.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).DateTime.Input.Text.Is("2024-12-23T08:13");

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        var writeListDataListPage2 = _driver.AttachWriteTileListDataListPage();
        WebDriverManager.WaitLoading();
        writeListDataListPage2.List.Items.Count.Is(1);
        writeListDataListPage2.List.Items.GetItem(0).NavigateToDetail.Click();

        //最後の編集を確認
        var writeListDataDetailPage3 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage3.Detail.List.Items.GetItem(0).DateTime.Input.Text.Is("2024-12-23T08:13");
    }

    [Test]
    public void Link()
    {
        var writeListDataListPage = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage.List.Create.Click();

        //作成
        var writeListDataDetailPage = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.Name.Input.Edit("Link編集");
        writeListDataDetailPage.Detail.List.Create.Click();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Link.Search.Click();

        writeListDataDetailPage.Detail.List.Items.GetItem(0).Link.LinkList.Items.GetItem(1).Element.Click();
        writeListDataDetailPage.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Link.Input.Text.Is("BBB");

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        WebDriverManager.WaitLoading();
        var writeListDataListPage1 = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage1.List.Items.Count.Is(1);
        writeListDataListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeListDataDetailPage2 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Link.Input.Text.Is("BBB");

        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Link.Search.Click();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Link.LinkList.Items.GetItem(2).Element.Click();
        writeListDataDetailPage2.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Link.Input.Text.Is("AAA");

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        var writeListDataListPage2 = _driver.AttachWriteTileListDataListPage();
        WebDriverManager.WaitLoading();
        writeListDataListPage2.List.Items.Count.Is(1);
        writeListDataListPage2.List.Items.GetItem(0).NavigateToDetail.Click();

        //最後の編集を確認
        var writeListDataDetailPage3 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage3.Detail.List.Items.GetItem(0).Link.Input.Text.Is("AAA");
    }

    [Test]
    public void Number()
    {
        var writeListDataListPage = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage.List.Create.Click();

        //作成
        var writeListDataDetailPage = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.Name.Input.Edit("Number編集");
        writeListDataDetailPage.Detail.List.Create.Click();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Number.Input.Edit("713");
        writeListDataDetailPage.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Number.Input.Text.Is("713");

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        WebDriverManager.WaitLoading();
        var writeListDataListPage1 = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage1.List.Items.Count.Is(1);
        writeListDataListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeListDataDetailPage2 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Number.Input.Text.Is("713");
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Number.Input.Edit("866");
        writeListDataDetailPage2.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Number.Input.Text.Is("866");

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        var writeListDataListPage2 = _driver.AttachWriteTileListDataListPage();
        WebDriverManager.WaitLoading();
        writeListDataListPage2.List.Items.Count.Is(1);
        writeListDataListPage2.List.Items.GetItem(0).NavigateToDetail.Click();

        //最後の編集を確認
        var writeListDataDetailPage3 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage3.Detail.List.Items.GetItem(0).Number.Input.Text.Is("866");
    }

    [Test]
    public void RadioGroup()
    {
        var writeListDataListPage = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage.List.Create.Click();

        //作成
        var writeListDataDetailPage = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.Name.Input.Edit("RadioGroup編集");
        writeListDataDetailPage.Detail.List.Create.Click();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).RadioA.Label.Click();
        writeListDataDetailPage.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).RadioA.Input.Checked.IsTrue();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).RadioB.Input.Checked.IsFalse();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).RadioC.Input.Checked.IsFalse();

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        WebDriverManager.WaitLoading();
        var writeListDataListPage1 = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage1.List.Items.Count.Is(1);
        writeListDataListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeListDataDetailPage2 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).RadioA.Input.Checked.IsTrue();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).RadioB.Input.Checked.IsFalse();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).RadioC.Input.Checked.IsFalse();

        writeListDataDetailPage2.Detail.List.Items.GetItem(0).RadioB.Label.Click();
        writeListDataDetailPage2.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).RadioA.Input.Checked.IsFalse();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).RadioB.Input.Checked.IsTrue();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).RadioC.Input.Checked.IsFalse();

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        var writeListDataListPage2 = _driver.AttachWriteTileListDataListPage();
        WebDriverManager.WaitLoading();
        writeListDataListPage2.List.Items.Count.Is(1);
        writeListDataListPage2.List.Items.GetItem(0).NavigateToDetail.Click();

        //最後の編集を確認
        var writeListDataDetailPage3 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage3.Detail.List.Items.GetItem(0).RadioA.Input.Checked.IsFalse();
        writeListDataDetailPage3.Detail.List.Items.GetItem(0).RadioB.Input.Checked.IsTrue();
        writeListDataDetailPage3.Detail.List.Items.GetItem(0).RadioC.Input.Checked.IsFalse();
    }

    [Test]
    public void Select()
    {
        var writeListDataListPage = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage.List.Create.Click();

        //作成
        var writeListDataDetailPage = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.Name.Input.Edit("Select編集");
        writeListDataDetailPage.Detail.List.Create.Click();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Select.Select.Edit("B");
        writeListDataDetailPage.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Select.Select.Text.Is("B");

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        WebDriverManager.WaitLoading();
        var writeListDataListPage1 = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage1.List.Items.Count.Is(1);
        writeListDataListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeListDataDetailPage2 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Select.Select.Text.Is("B");

        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Select.Select.Edit("A");
        writeListDataDetailPage2.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();

        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Select.Select.Text.Is("A");

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        var writeListDataListPage2 = _driver.AttachWriteTileListDataListPage();
        WebDriverManager.WaitLoading();
        writeListDataListPage2.List.Items.Count.Is(1);
        writeListDataListPage2.List.Items.GetItem(0).NavigateToDetail.Click();

        //最後の編集を確認
        var writeListDataDetailPage3 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage3.Detail.List.Items.GetItem(0).Select.Select.Text.Is("A");
    }

    [Test]
    public void SelectLink()
    {
        var writeListDataListPage = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage.List.Create.Click();

        //作成
        var writeListDataDetailPage = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.Name.Input.Edit("SelectLink編集");
        writeListDataDetailPage.Detail.List.Create.Click();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).SelectLink.Element.Click();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).SelectLink.Select.Edit("BBB");
        writeListDataDetailPage.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).SelectLink.Select.Text.Is("BBB");

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        WebDriverManager.WaitLoading();
        var writeListDataListPage1 = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage1.List.Items.Count.Is(1);
        writeListDataListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeListDataDetailPage2 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).SelectLink.Select.Text.Is("BBB");

        writeListDataDetailPage.Detail.List.Items.GetItem(0).SelectLink.Element.Click();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).SelectLink.Select.Edit("AAA");
        writeListDataDetailPage2.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();

        writeListDataDetailPage2.Detail.List.Items.GetItem(0).SelectLink.Select.Text.Is("AAA");

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        var writeListDataListPage2 = _driver.AttachWriteTileListDataListPage();
        WebDriverManager.WaitLoading();
        writeListDataListPage2.List.Items.Count.Is(1);
        writeListDataListPage2.List.Items.GetItem(0).NavigateToDetail.Click();

        //最後の編集を確認
        var writeListDataDetailPage3 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage3.Detail.List.Items.GetItem(0).SelectLink.Select.Text.Is("AAA");
    }

    [Test]
    public void Text()
    {
        var writeListDataListPage = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage.List.Create.Click();

        //作成
        var writeListDataDetailPage = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.Name.Input.Edit("Text編集");
        writeListDataDetailPage.Detail.List.Create.Click();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Text.Input.Edit("藤壺");
        writeListDataDetailPage.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Text.Input.Text.Is("藤壺");

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        WebDriverManager.WaitLoading();
        var writeListDataListPage1 = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage1.List.Items.Count.Is(1);
        writeListDataListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeListDataDetailPage2 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Text.Input.Text.Is("藤壺");
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Text.Input.Edit("夕顔");
        writeListDataDetailPage2.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Text.Input.Text.Is("夕顔");

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        var writeListDataListPage2 = _driver.AttachWriteTileListDataListPage();
        WebDriverManager.WaitLoading();
        writeListDataListPage2.List.Items.Count.Is(1);
        writeListDataListPage2.List.Items.GetItem(0).NavigateToDetail.Click();

        //最後の編集を確認
        var writeListDataDetailPage3 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage3.Detail.List.Items.GetItem(0).Text.Input.Text.Is("夕顔");
    }

    [Test]
    public void Time()
    {
        var writeListDataListPage = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage.List.Create.Click();

        //作成
        var writeListDataDetailPage = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.Name.Input.Edit("Time編集");
        writeListDataDetailPage.Detail.List.Create.Click();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Time.Input.Edit(7, 55);
        writeListDataDetailPage.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).Time.Input.Text.Is("07:55");

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        WebDriverManager.WaitLoading();
        var writeListDataListPage1 = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage1.List.Items.Count.Is(1);
        writeListDataListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeListDataDetailPage2 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Time.Input.Text.Is("07:55");
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Time.Input.Edit(8, 13);
        writeListDataDetailPage2.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).Time.Input.Text.Is("08:13");

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        var writeListDataListPage2 = _driver.AttachWriteTileListDataListPage();
        WebDriverManager.WaitLoading();
        writeListDataListPage2.List.Items.Count.Is(1);
        writeListDataListPage2.List.Items.GetItem(0).NavigateToDetail.Click();

        //最後の編集を確認
        var writeListDataDetailPage3 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage3.Detail.List.Items.GetItem(0).Time.Input.Text.Is("08:13");
    }

    [Test]
    public void File()
    {
        var writeListDataListPage = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage.List.Create.Click();

        //作成
        var writeListDataDetailPage = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.Name.Input.Edit("File編集");
        writeListDataDetailPage.Detail.List.Create.Click();
        var filePath = Path.Combine(Path.GetDirectoryName(GetType().Assembly.Location)!, @"Scenario\TestData\地図.pdf");
        writeListDataDetailPage.Detail.List.Items.GetItem(0).File.Upload(filePath);
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage.Detail.List.Items.GetItem(0).File.Element.Text.Is("地図.pdf");

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        WebDriverManager.WaitLoading();
        var writeListDataListPage1 = _driver.AttachWriteTileListDataListPage();
        writeListDataListPage1.List.Items.Count.Is(1);
        writeListDataListPage1.List.Items.GetItem(0).NavigateToDetail.Click();

        //更新
        var writeListDataDetailPage2 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).File.Element.Text.Is("地図.pdf");

        writeListDataDetailPage2.Detail.List.Items.GetItem(0).File.Delete.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.SubmitButton.Submit.Click();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage2.Detail.List.Items.GetItem(0).File.Element.Text.Is(string.Empty);

        //一覧に戻る
        _driver.AttachMainLeft().WriteTileListData.Click();
        var writeListDataListPage2 = _driver.AttachWriteTileListDataListPage();
        WebDriverManager.WaitLoading();
        writeListDataListPage2.List.Items.Count.Is(1);
        writeListDataListPage2.List.Items.GetItem(0).NavigateToDetail.Click();

        //最後の編集を確認
        var writeListDataDetailPage3 = _driver.AttachWriteTileListDataDetailPage();
        WebDriverManager.WaitLoading();
        writeListDataDetailPage3.Detail.List.Items.GetItem(0).File.Element.Text.Is(string.Empty);
    }
}
