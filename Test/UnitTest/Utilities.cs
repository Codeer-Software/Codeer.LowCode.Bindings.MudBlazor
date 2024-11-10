using Codeer.LowCode.Blazor.DataIO.Db.Definition;
using Codeer.LowCode.Blazor.DesignLogic;
using Codeer.LowCode.Blazor.DesignLogic.Check;
using Codeer.LowCode.Blazor.Json;
using Codeer.LowCode.Blazor.Repository.Design;
using Codeer.LowCode.Blazor.Repository.Match;

namespace UnitTest
{
    class RawPageFrameDesigns : IPageFrameDesigns
    {
        List<PageFrameDesign> _pageFrames;

        internal RawPageFrameDesigns() => _pageFrames = new();
        internal RawPageFrameDesigns(List<PageFrameDesign> pageFrames) => _pageFrames = pageFrames.ToList();

        public string ResolvedMainPageFrameName => string.Empty;
        public ResolvedPageFrame? FindResolved(string? name) => null;
        public List<string> GetPageFrameNames() => _pageFrames.Select(e => e.Name).ToList();
        public PageFrameDesign? Find(string? name) => _pageFrames.FirstOrDefault(e => e.Name == name);

        internal List<PageFrameDesign> ToList() => _pageFrames.ToList();

        internal bool Any(Func<PageFrameDesign, bool> condition) => _pageFrames.Any(condition);
        internal void Add(PageFrameDesign page) => _pageFrames.Add(page);
        internal void Remove(PageFrameDesign pageFrames) => _pageFrames.Add(pageFrames);

        internal void Remove(string name)
        {
            var i = _pageFrames.FindIndex(e => e.Name == name);
            if (i == -1) return;
            _pageFrames.RemoveAt(i);
        }

        internal void Sort()
        {
            var list = _pageFrames.OrderBy(e => e.Name).ToList();
            _pageFrames.Clear();
            _pageFrames.AddRange(list);
        }

        internal void SetData(PageFrameDesign pageFrameDesign)
        {
            var i = _pageFrames.FindIndex(e => e.Name == pageFrameDesign.Name);
            if (i == -1)
            {
                _pageFrames.Add(pageFrameDesign);
            }
            else
            {
                _pageFrames[i] = pageFrameDesign;
            }
        }

        public IPageFrameDesigns Clone() => new RawPageFrameDesigns(_pageFrames.JsonClone());
    }

    public static class Utilities
    {
        public static Dictionary<string, string> CreateScripts(string moduleName = "mod") => new()
        {
            { moduleName, "void Func1(){}" }
        };

        public static IPageFrameDesigns CreatePageFrames() => new RawPageFrameDesigns(
        [
            new PageFrameDesign { Name = "PageFrame" }
        ]);

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
