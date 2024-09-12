using Codeer.LowCode.Blazor.DataIO.Db.Definition;
using Codeer.LowCode.Blazor.DesignLogic;
using Codeer.LowCode.Blazor.DesignLogic.Check;
using Codeer.LowCode.Blazor.Repository.Design;
using Codeer.LowCode.Blazor.Repository.Match;

namespace BindingsTest
{
    public static class Utilities
    {
        public static Dictionary<string, string> CreateScripts(string moduleName = "mod") => new()
        {
            { moduleName, "void Func1(){}" }
        };

        public static List<PageFrameDesign> CreatePageFrames() =>
        [
            new PageFrameDesign { Name = "PageFrame" }
        ];

        public static ModuleDesign CreateModule(string moduleName = "mod") => new()
            { Name = moduleName, DataSourceName = "datasource", DbTable = "table" };

        public static Dictionary<string, List<DbTableDefinition>> CreateDataSource() =>
            CreateDataSource("datasource", "table", "DbColumn");

        public static Dictionary<string, List<DbTableDefinition>> CreateDataSource(string dataSource,
            string tableName, params string[] columns)
        {
            var dataSources = new Dictionary<string, List<DbTableDefinition>>();
            var tables = new List<DbTableDefinition>
            {
                new()
                {
                    Name = tableName,
                    Columns = columns.Select(col => new DbColumnDefinition { Name = col }).ToList()
                }
            };
            dataSources[dataSource] = tables;
            return dataSources;
        }

        public static (DesignData, ModuleDesign) CreateDesignData(string moduleName = "mod")
        {
            var designData = new DesignData
            {
                Scripts = CreateScripts(moduleName),
                PageFrames = CreatePageFrames()
            };
            var module = CreateModule(moduleName);
            designData.Modules.Add(module);
            return (designData, module);
        }

        public static SearchCondition CreateSearchCondition(string moduleName) => new()
        {
            ModuleName = moduleName
        };

        public static void AssertFieldLocation(this DesignCheckInfo info, string module, string field, string member)
        {
            Assert.Multiple(() =>
            {
                Assert.That(info, Is.InstanceOf<FieldDesignCheckInfo>());
                Assert.That(((FieldDesignCheckInfo)info).Location.Module, Is.EqualTo(module));
                Assert.That(((FieldDesignCheckInfo)info).Location.Field, Is.EqualTo(field));
                Assert.That(((FieldDesignCheckInfo)info).Location.Member, Is.EqualTo(member));
            });
        }

        public static void AssertModuleLocation(this DesignCheckInfo info, string module, string member)
        {
            Assert.Multiple(() =>
            {
                Assert.That(info, Is.InstanceOf<FieldDesignCheckInfo>());
                Assert.That(((ModuleDesignCheckInfo)info).Location.Module, Is.EqualTo(module));
                Assert.That(((ModuleDesignCheckInfo)info).Location.Member, Is.EqualTo(member));
            });
        }

        public static void AssertPageFrameLocation(this DesignCheckInfo info, string pageFrame, string member)
        {
            Assert.Multiple(() =>
            {
                Assert.That(info, Is.InstanceOf<FieldDesignCheckInfo>());
                Assert.That(((PageFrameDesignCheckInfo)info).Location.PageFrame, Is.EqualTo(pageFrame));
                Assert.That(((PageFrameDesignCheckInfo)info).Location.Member, Is.EqualTo(member));
            });
        }
    }
}
