namespace LowCodeApp.Designer.Lib.ExcelImport
{
    internal static class Arrays
    {
        internal static string GetOrDefault(this string[] a, int index)
        {
            if (index < a.Length) return a[index];
            return "";
        }
    }
}
