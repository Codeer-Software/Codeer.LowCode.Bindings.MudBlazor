using Codeer.LowCode.Blazor.Repository.Design;
using static LowCodeApp.Designer.Lib.ExcelImport.Strings;

namespace LowCodeApp.Designer.Lib.ExcelImport
{
    internal static class Layouts
    {
        internal static void AddHeaderLayout(this DetailLayoutDesign design, ModuleDesign module, string name)
        {
            var field = new LabelFieldDesign()
            {
                Name = "Header",
                Text = PascalCase(name),
                Style = LabelStyle.H1
            };
            module.Fields.Add(field);

            ((GridLayoutDesign)design.Layout).Rows.Add(new GridRow
            {
                Columns = [new GridColumn
                {
                    Layout = new FieldLayoutDesign("Header"),
                    HorizontalAlignment = HorizontalAlignment.Center
                }]
            });
        }

        internal static void AddSubmitLayout(this DetailLayoutDesign design, ModuleDesign module)
        {
            var field = new SubmitButtonFieldDesign
            {
                Name = "Submit"
            };
            module.Fields.Add(field);

            ((GridLayoutDesign)design.Layout).Rows.Add(new GridRow
            {
                Columns = [new GridColumn
                {
                    Layout = new FieldLayoutDesign("Submit"),
                    HorizontalAlignment = HorizontalAlignment.Center
                }]
            });
        }

        internal static void AddField(this DetailLayoutDesign design, ModuleDesign module, string name)
        {
            var field = new LabelFieldDesign()
            {
                Name = PascalCase(name) + "Label",
                Text = string.Empty,
                RelativeField = PascalCase(name)
            };
            module.Fields.Add(field);

            ((GridLayoutDesign)design.Layout).Rows.Add(new GridRow
            {
                Columns = [new GridColumn
                {
                    Layout = new FieldLayoutDesign(PascalCase(name) + "Label"),
                    Width = 150,
                    VerticalAlignment = VerticalAlignment.Middle
                }, new GridColumn()
                {
                    Layout = new FieldLayoutDesign(PascalCase(name)),
                }]
            });
        }

        internal static void AddRadioGroup(this DetailLayoutDesign design, ModuleDesign module, string name, int howMany)
        {
            var field = new LabelFieldDesign()
            {
                Name = PascalCase(name) + "Label",
                Text = PascalCase(name)
            };
            module.Fields.Add(field);
            design.DataOnlyFields.Add(PascalCase(name));

            ((GridLayoutDesign)design.Layout).Rows.Add(new GridRow
            {
                Columns =
                [
                    new GridColumn
                    {
                        Layout = new FieldLayoutDesign(PascalCase(name) + "Label"),
                        Width = 150,
                        VerticalAlignment = VerticalAlignment.Middle
                    },
                    new GridColumn
                    {
                        Layout = new GridLayoutDesign
                        {
                            IsFlowLayout = true,
                            Rows =
                            [
                                new GridRow
                                {
                                    Columns = Enumerable.Range(0, howMany).Select(i => new GridColumn
                                    {
                                        Layout = new FieldLayoutDesign(PascalCase(name) + "Item" + i)
                                    }).ToList()
                                }
                            ]
                        }
                    }
                ]
            });
        }

        internal static void AddList(this DetailLayoutDesign design, string name, string module)
        {
            ((GridLayoutDesign)design.Layout).Rows.Add(new GridRow
            {
                Columns = [new GridColumn
                {
                    Layout = new FieldLayoutDesign(PascalCase(name) + "List" + module),
                }]
            });
        }
    }
}
