using ClosedXML.Excel;
using Codeer.LowCode.Blazor.Designer.Config;
using Codeer.LowCode.Blazor.Json;
using Codeer.LowCode.Blazor.Repository.Design;
using Codeer.LowCode.Blazor.SystemSettings;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace LowCodeApp.Designer.Lib.ExcelImport
{
    internal class ExcelImporter
    {
        internal DataSourceType DataSourceType { get; set; }
        internal string ProjectPath { get; set; } = "";
        internal string DataSourceName { get; set; } = "";
        internal string DdlFileName { get; set; } = "ddl.txt";

        private bool IsRowUsed(IXLRow row) => (!row.Cell(2).Value.IsBlank);
        private string CellValue(IXLCell cell) => cell.Value.IsBlank ? "" : cell.GetText();

        internal string Import(string inputFile)
        {
            if (string.IsNullOrEmpty(inputFile) || !File.Exists(inputFile))
            {
                Debug.WriteLine("Input file not found.");
                return string.Empty;
            }

            if (string.IsNullOrEmpty(DataSourceName))
            {
                DataSourceName = Path.GetFileNameWithoutExtension(inputFile);
            }

            //DataSource
            try
            {
                var settingsFile = File.ReadAllText(Path.Combine(ProjectPath, "designer.settings.json"));
                var config = JsonConverterEx.DeserializeObject<DesignerSettings>(settingsFile)!;
                var dataSource = config.DataSources.FirstOrDefault(ds => ds.Name == DataSourceName);
                if (dataSource != null) DataSourceType = dataSource.DataSourceType;
            }
            catch { }

            XLWorkbook workbook;
            using (var fileStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                workbook = new XLWorkbook(fileStream);
            }

            var ddl = new StringBuilder();
            var modules = new List<string>();
            for (var i = 0; i < workbook.Worksheets.Count; i++)
            {
                var worksheet = workbook.Worksheets.Worksheet(i + 1);
                var tableName = worksheet.Name;
                var moduleName = Strings.PascalCase(tableName);

                var definitions = worksheet.RowsUsed(IsRowUsed)
                    .Select(r => new Def(CellValue(r.Cell(1)), CellValue(r.Cell(2)),
                        r.Cells(3, 128).TakeWhile(c => !c.Value.IsBlank).Select(CellValue).ToArray())).ToList();

                // DDL
                var databaseColumnDefinitions = definitions.Where(r => !string.IsNullOrEmpty(r.Name))
                    .Select(r => $"  {r.Name} {DbMapping.MapToColumnType(DataSourceType, r.Type, r.Name)}");
                ddl.AppendLine($"CREATE TABLE {tableName} (");
                ddl.AppendLine(string.Join(",\n", databaseColumnDefinitions));
                ddl.AppendLine(");");
                ddl.AppendLine("");

                // Module
                modules.Add(moduleName);
                var module = new ModuleDesign
                {
                    Name = moduleName,
                    DataSourceName = DataSourceName,
                    DbTable = tableName,
                };
                foreach (var def in definitions)
                {
                    module.Fields.Add(FieldMapping.MapToFieldDesign(def.Name, def.Type, def.Args));
                    if (def.Type == "RadioGroup")
                    {
                        module.Fields.AddRange(FieldMapping.MapRadioButtons(def.Name, def.Args));
                    }
                }

                var defaultLayout = module.DetailLayouts[""];
                // Clear layout
                defaultLayout.Layout = new GridLayoutDesign()
                {
                    Rows = []
                };

                defaultLayout.AddHeaderLayout(module, tableName);
                foreach (var def in definitions)
                {
                    switch (def.Type)
                    {
                        case "Id":
                            break;
                        case "RadioGroup":
                            defaultLayout.AddRadioGroup(module, def.Name, def.Args.Length);
                            break;
                        case "List":
                            defaultLayout.AddList(def.Name, def.Args.GetOrDefault(0));
                            break;
                        default:
                            defaultLayout.AddField(module, def.Name);
                            break;
                    }
                }

                defaultLayout.AddSubmitLayout(module);

                var listLayout = module.ListLayouts[""];
                listLayout.Elements =
                [
                    definitions.Where(def => (def.Type != "Id") && (def.Type != "List")).Select(def => new ListElement
                    {
                        FieldName = Strings.PascalCase(def.Name),
                    }).ToList()
                ];

                File.WriteAllText(Path.Combine(GetModuleOutputPath(), $"{moduleName}.mod.json"),
                    JsonConverterEx.SerializeObject(module));
            }

            var pageFrame = new PageFrameDesign();
            try
            {
                var pageFrameJson = File.ReadAllText(Path.Combine(GetPageFrameOutputPath(), "Main.frm.json"));
                pageFrame = JsonConverterEx.DeserializeObject<PageFrameDesign>(pageFrameJson) ?? new PageFrameDesign();
            }
            catch { }

            foreach (var module in modules)
            {
                if (pageFrame.Left.Links.Any(e => e.Module == module)) continue;
                pageFrame.Left.Links.Add(new PageLink
                {
                    Module = module,
                    Title = module,
                });
            }

            File.WriteAllText(Path.Combine(GetPageFrameOutputPath(), "Main.frm.json"),
                JsonConverterEx.SerializeObject(pageFrame));

            return ddl.ToString();
        }

        private string GetDdlOutputPath() => ProjectPath;

        private string GetModuleOutputPath() => Path.Combine(ProjectPath, "Modules");

        private string GetPageFrameOutputPath() => Path.Combine(ProjectPath, "PageFrames");

        internal record Def(string Name, string Type, string[] Args);
    }
}
