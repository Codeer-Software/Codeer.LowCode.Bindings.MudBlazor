using Codeer.LowCode.Bindings.MudBlazor.Designs;
using Codeer.LowCode.Blazor.DesignLogic;
using Codeer.LowCode.Blazor.DesignLogic.Refactor;

namespace UnitTest.Rename
{
    public class MudChartFieldDesignTest
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
            var field = new MudChartFieldDesign { SearchCondition = Utilities.CreateSearchCondition("ref1") };
            var result = field.ChangeName(context);
            Assert.That(result.RenameNeeded);
            result.RenameAction();
            Assert.That(field.SearchCondition.ModuleName, Is.EqualTo("ref2"));
        }
    }
}
