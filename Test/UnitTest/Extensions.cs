using Codeer.LowCode.Blazor.DesignLogic;
using Codeer.LowCode.Blazor.Repository.Design;

namespace UnitTest
{
    public static class Extensions
    {
        public static void Add(this IModuleDesigns designs, ModuleDesign design)
        {
            designs.GetType().GetMethod("Add", System.Reflection.BindingFlags.NonPublic| System.Reflection.BindingFlags.Instance)?.Invoke(designs, new object[] { design });

            //((dynamic)designs).Add(design.Name, design);
        }
    }

}
