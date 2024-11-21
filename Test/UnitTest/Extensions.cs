using System.Reflection;
using Codeer.LowCode.Blazor.DesignLogic;
using Codeer.LowCode.Blazor.Repository.Design;

namespace UnitTest
{
    public static class Extensions
    {
        public static void Add(this IModuleDesigns designs, ModuleDesign design)
        {
            designs.GetType().GetMethod("Add", BindingFlags.Public | BindingFlags.Instance)?.Invoke(designs, new object[] { design });

            //((dynamic)designs).Add(design.Name, design);
        }
    }

}
