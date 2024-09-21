using Codeer.LowCode.Bindings.MudBlazor.Designs;
using Codeer.LowCode.Blazor.DesignLogic.Check;

namespace UnitTest.DesignCheck
{
    public class MudChartFieldDesignCheck
    {
        [Test]
        public void Success()
        {
            var (designData, module) = Utilities.CreateDesignData();
            var field = new MudChartFieldDesign
            {
                Name = "MudChart1",
                SearchCondition = Utilities.CreateSearchCondition("ref1"),
            };
            module.Fields.Add(field);
            var ref1 = Utilities.CreateModule("ref1");
            designData.Modules.Add(ref1);
            var ret = field.CheckDesign(new DesignCheckContext("mod", designData, Utilities.CreateDataSource()));
            Assert.That(ret.Count, Is.EqualTo(0));
        }

        [Test]
        public void NoMatchModules()
        {
            var (designData, module) = Utilities.CreateDesignData();
            var field = new MudChartFieldDesign
            {
                Name = "MudChart1",
                SearchCondition = Utilities.CreateSearchCondition("ref1"),
            };
            module.Fields.Add(field);
            var ret = field.CheckDesign(new DesignCheckContext("mod", designData, Utilities.CreateDataSource()));
            Assert.That(ret.Count, Is.EqualTo(1));
            Assert.That(ret[0].Message, Is.EqualTo("モジュール 'ref1' が存在しません。"));
            ret[0].AssertFieldLocation("mod", "MudChart1", "SearchCondition.ModuleName");
        }
    }
}
