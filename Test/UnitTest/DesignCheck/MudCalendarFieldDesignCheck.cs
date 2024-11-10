using Codeer.LowCode.Bindings.MudBlazor.Designs;
using Codeer.LowCode.Blazor.DesignLogic;
using Codeer.LowCode.Blazor.DesignLogic.Check;
using Codeer.LowCode.Blazor.Repository.Design;

namespace UnitTest.DesignCheck
{
    public class MudCalendarFieldDesignCheck
    {
        [Test]
        public void Success()
        {
            var (designData, module) = Utilities.CreateDesignData();
            var field = new MudCalendarFieldDesign
            {
                Name = "MudCalendar1",
                TextField = "Text1",
                StartDateField = "StartData1",
                EndDateField = "EndData1",
                AllDayField = "AllDay1",
                DetailLayoutName = "Layout1",
                OnDataChanged = "Func1",
                SearchCondition = Utilities.CreateSearchCondition("ref1"),
            };
            module.Fields.Add(field);
            var ref1 = Utilities.CreateModule("ref1");
            ref1.DetailLayouts["Layout1"] = new();
            designData.Modules.Add(ref1);
            ref1.Fields.Add(new TextFieldDesign { Name = "Text1" });
            ref1.Fields.Add(new DateTimeFieldDesign { Name = "StartData1" });
            ref1.Fields.Add(new DateTimeFieldDesign { Name = "EndData1" });
            ref1.Fields.Add(new BooleanFieldDesign { Name = "AllDay1" });
            var ret = field.CheckDesign(new DesignCheckContext("mod", designData, Utilities.CreateDataSource()));
            Assert.That(ret.Count, Is.EqualTo(0));
        }

        [Test]
        public void NoMatchModules()
        {
            var (designData, module) = Utilities.CreateDesignData();
            var field = new MudCalendarFieldDesign
            {
                Name = "MudCalendar1",
                TextField = "Text1",
                StartDateField = "StartData1",
                EndDateField = "EndData1",
                AllDayField = "AllDay1",
                DetailLayoutName = "Layout1",
                OnDataChanged = "Func1",
                SearchCondition = Utilities.CreateSearchCondition("ref1"),
            };
            module.Fields.Add(field);
            var ret = field.CheckDesign(new DesignCheckContext("mod", designData, Utilities.CreateDataSource()));
            Assert.That(ret.Count, Is.EqualTo(1));
            Assert.That(ret[0].Message, Is.EqualTo("モジュール 'ref1' が存在しません。"));
            ret[0].AssertFieldLocation("mod", "MudCalendar1", "SearchCondition.ModuleName");
        }

        [Test]
        public void NoMatchFields()
        {
            var (designData, module) = Utilities.CreateDesignData();
            var field = new MudCalendarFieldDesign
            {
                Name = "MudCalendar1",
                TextField = "Text1",
                StartDateField = "StartData1",
                EndDateField = "EndData1",
                AllDayField = "AllDay1",
                DetailLayoutName = "Layout1",
                OnDataChanged = "Func1",
                SearchCondition = Utilities.CreateSearchCondition("ref1"),
            };
            module.Fields.Add(field);
            var ref1 = Utilities.CreateModule("ref1");
            ref1.DetailLayouts["Layout1"] = new();
            designData.Modules.Add(ref1);
            var ret = field.CheckDesign(new DesignCheckContext("mod", designData, Utilities.CreateDataSource()));
            Assert.That(ret.Count, Is.EqualTo(4));
            Assert.Multiple(() =>
            {
                Assert.That(ret[0].Message, Is.EqualTo("フィールド 'Text1' がモジュール 'ref1' に存在しません。"));
                Assert.That(ret[1].Message, Is.EqualTo("フィールド 'StartData1' がモジュール 'ref1' に存在しません。"));
                Assert.That(ret[2].Message, Is.EqualTo("フィールド 'EndData1' がモジュール 'ref1' に存在しません。"));
                Assert.That(ret[3].Message, Is.EqualTo("フィールド 'AllDay1' がモジュール 'ref1' に存在しません。"));
            });
            ret[0].AssertFieldLocation("mod", "MudCalendar1", "TextField");
            ret[1].AssertFieldLocation("mod", "MudCalendar1", "StartDateField");
            ret[2].AssertFieldLocation("mod", "MudCalendar1", "EndDateField");
            ret[3].AssertFieldLocation("mod", "MudCalendar1", "AllDayField");
        }

        [Test]
        public void NoMatchFunctions()
        {
            var (designData, module) = Utilities.CreateDesignData();
            var field = new MudCalendarFieldDesign
            {
                Name = "MudCalendar1",
                OnDataChanged = "Func11",
            };
            module.Fields.Add(field);
            var ret = field.CheckDesign(new DesignCheckContext("mod", designData, Utilities.CreateDataSource()));
            Assert.That(ret.Count, Is.EqualTo(1));
            Assert.That(ret[0].Message, Is.EqualTo("関数 'void Func11()' が存在しません。"));
            ret[0].AssertFieldLocation("mod", "MudCalendar1", "OnDataChanged");
        }

        [Test]
        public void NoMatchLayouts()
        {
            var (designData, module) = Utilities.CreateDesignData();
            var field = new MudCalendarFieldDesign
            {
                Name = "MudCalendar1",
                DetailLayoutName = "Layout1",
                SearchCondition = Utilities.CreateSearchCondition("ref1"),
            };
            module.Fields.Add(field);
            var ref1 = Utilities.CreateModule("ref1");
            designData.Modules.Add(ref1);
            var ret = field.CheckDesign(new DesignCheckContext("mod", designData, Utilities.CreateDataSource()));
            Assert.That(ret.Count, Is.EqualTo(1));
            Assert.That(ret[0].Message, Is.EqualTo("レイアウト 'Layout1' がモジュール 'ref1' に存在しません。"));
            ret[0].AssertFieldLocation("mod", "MudCalendar1", "DetailLayoutName");
        }
    }
}
