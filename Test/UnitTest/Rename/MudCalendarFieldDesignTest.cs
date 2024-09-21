using Codeer.LowCode.Bindings.MudBlazor.Designs;
using Codeer.LowCode.Blazor.DesignLogic;
using Codeer.LowCode.Blazor.DesignLogic.Refactor;
using Codeer.LowCode.Blazor.Repository.Design;

namespace UnitTest.Rename
{
    public class MudCalendarFieldDesignTest
    {
        [Test]
        public void ChangeSearchCondition()
        {
            var designData = new DesignData();
            var context = new RenameContext(designData)
            {
                Source = "ref1",
                Destination = "ref2",
                Type = RenameType.Module,
            };
            var field = new MudCalendarFieldDesign { SearchCondition = Utilities.CreateSearchCondition("ref1") };
            var result = field.ChangeName(context);
            Assert.That(result.RenameNeeded);
            result.RenameAction();
            Assert.That(field.SearchCondition.ModuleName, Is.EqualTo("ref2"));
        }

        [Test]
        public void ChangeDetailLayoutName()
        {
            var designData = new DesignData();
            var context = new RenameContext(designData)
            {
                ModuleName = "ref1",
                Source = "Layout1",
                Destination = "Layout2",
                Type = RenameType.Layout,
                LayoutType = ModuleLayoutType.Detail,
            };
            var field = new MudCalendarFieldDesign
            {
                DetailLayoutName = "Layout1",
                SearchCondition = Utilities.CreateSearchCondition("ref1")
            };
            var result = field.ChangeName(context);
            Assert.That(result.RenameNeeded);
            result.RenameAction();
            Assert.That(field.DetailLayoutName, Is.EqualTo("Layout2"));
        }

        [Test]
        public void ChangeTextField()
        {
            var designData = new DesignData();
            var context = new RenameContext(designData)
            {
                ModuleName = "ref1",
                Source = "Text1",
                Destination = "Text2",
                Type = RenameType.Field,
            };
            var field = new MudCalendarFieldDesign
            {
                TextField = "Text1",
                SearchCondition = Utilities.CreateSearchCondition("ref1")
            };
            var result = field.ChangeName(context);
            Assert.That(result.RenameNeeded);
            result.RenameAction();
            Assert.That(field.TextField, Is.EqualTo("Text2"));
        }

        [Test]
        public void ChangeStartDateField()
        {
            var designData = new DesignData();
            var context = new RenameContext(designData)
            {
                ModuleName = "ref1",
                Source = "StartData1",
                Destination = "StartData2",
                Type = RenameType.Field,
            };
            var field = new MudCalendarFieldDesign
            {
                StartDateField = "StartData1",
                SearchCondition = Utilities.CreateSearchCondition("ref1")
            };
            var result = field.ChangeName(context);
            Assert.That(result.RenameNeeded);
            result.RenameAction();
            Assert.That(field.StartDateField, Is.EqualTo("StartData2"));
        }

        [Test]
        public void ChangeEndDateField()
        {
            var designData = new DesignData();
            var context = new RenameContext(designData)
            {
                ModuleName = "ref1",
                Source = "EndData1",
                Destination = "EndData2",
                Type = RenameType.Field,
            };
            var field = new MudCalendarFieldDesign
            {
                EndDateField = "EndData1",
                SearchCondition = Utilities.CreateSearchCondition("ref1")
            };
            var result = field.ChangeName(context);
            Assert.That(result.RenameNeeded);
            result.RenameAction();
            Assert.That(field.EndDateField, Is.EqualTo("EndData2"));
        }

        [Test]
        public void ChangeAllDayField()
        {
            var designData = new DesignData();
            var context = new RenameContext(designData)
            {
                ModuleName = "ref1",
                Source = "AllDay1",
                Destination = "AllDay2",
                Type = RenameType.Field,
            };
            var field = new MudCalendarFieldDesign
            {
                AllDayField = "AllDay1",
                SearchCondition = Utilities.CreateSearchCondition("ref1")
            };
            var result = field.ChangeName(context);
            Assert.That(result.RenameNeeded);
            result.RenameAction();
            Assert.That(field.AllDayField, Is.EqualTo("AllDay2"));
        }
    }
}
