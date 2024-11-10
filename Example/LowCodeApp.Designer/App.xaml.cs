using Codeer.LowCode.Blazor.Designer;
using Codeer.LowCode.Blazor.Designer.Models;
using Codeer.LowCode.Blazor.Designer.Views.Windows;
using LowCodeApp.Client.Shared.ScriptObjects;
using LowCodeApp.Designer.Lib.ExcelImport;
using LowCodeApp.Designer.Lib.SeleniumPageObject;
using LowCodeApp.Designer.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Win32;
using System.Configuration;
using System.IO;
using System.IO.Compression;
using System.Windows;
using Codeer.LowCode.Bindings.MudBlazor.Installer;
using MudBlazor.Services;

namespace LowCodeApp.Designer
{
    public partial class App : DesignerApp
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MudBlazorLoader.LoadAssemblies();

            Codeer.LowCode.Blazor.License.LicenseManager.IsAutoUpdate =
                bool.TryParse(ConfigurationManager.AppSettings["IsLicenseAutoUpdate"], out var val) ? val : true;

            Services.AddSingleton<IDbAccessorFactory, DbAccessorFactory>();
            Services.AddMudServices();
            ScriptRuntimeTypeManager.AddType(typeof(ExcelCellIndex));
            ScriptRuntimeTypeManager.AddType(typeof(LowCodeApp.Client.Shared.ScriptObjects.Excel));
            ScriptRuntimeTypeManager.AddService(new Toaster(null!));
            ScriptRuntimeTypeManager.AddService(new WebApiService(null!, null!));
            ScriptRuntimeTypeManager.AddType<WebApiResult>();
            ScriptRuntimeTypeManager.AddService(new MailService());

            BlazorRuntime.InstallBundleCss("LowCodeApp.Client.Shared");
            BlazorRuntime.InstallAssemblyInitializer(typeof(MudBlazorInstaller).Assembly);
            BlazorRuntime.InstallRenderProvider(typeof(MudBlazorInstaller));

            IconCandidate.Icons.AddRange(LowCodeApp.Designer.Properties.Resources.bootstrap_icons
                .Split(["\r\n", "\n"], StringSplitOptions.RemoveEmptyEntries).Order());

            DesignerTemplateCandidate.Templates.Add(new DesignerTemplate
            {
                Create = CreateGettingStandard,
                Name = "GettingStarted",
                Description =
                    "The sample project reads, writes, and deletes data in the \r\n\"C:\\Codeer.LowCode.Blazor.Local\"; folder. \r\n;Please do not place any data in this folder that would be problematic if overwritten or deleted. You can change this folder later.",
            });
            DesignerTemplateCandidate.Templates.Add(new DesignerTemplate
            {
                Create = CreateEmpty,
                Name = "Empty",
                Description = "Empty template.",
            });

            base.OnStartup(e);

            MainWindow.Title = "LowCodeApp";
            DesignerEnvironment.AddMainMenu(ExportPageObject, "Tools", "Export PageObject");
        }

        private void ExportPageObject()
        {
            if (string.IsNullOrEmpty(DesignerEnvironment.CurrentFileDirectory))
            {
                return;
            }

            var nameInputDialog = new NameInputDialog();
            if (nameInputDialog.ShowDialog() != true)
            {
                return;
            }

            var ns = nameInputDialog.NameText;

            var folderDialog = new OpenFolderDialog();
            if (folderDialog.ShowDialog() != true)
            {
                return;
            }

            var target = folderDialog.FolderName;
            var designData = DesignerEnvironment.GetDesignData();
            new SeleniumPageObjectBuilder
            {
                TargetPath = target,
                Namespace = ns,
            }.Build(designData);

            DesignerEnvironment.ShowToast("PageObject exported", true);
        }

        static void CreateEmpty(string path)
        {
            using Stream stream = new MemoryStream(LowCodeApp.Designer.Properties.Resources.EmptyTemplate);
            ZipFile.ExtractToDirectory(stream, path);
        }

        static void CreateGettingStandard(string path)
        {
            using (Stream stream = new MemoryStream(LowCodeApp.Designer.Properties.Resources.GettingStartedTemplate))
            {
                ZipFile.ExtractToDirectory(stream, path);
            }

            var dbPath = "C:\\Codeer.LowCode.Blazor.Local\\Data\\sqlite_sample.db";
            if (!File.Exists(dbPath))
            {
                if (!File.Exists(dbPath))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(dbPath)!);
                    File.WriteAllBytes(dbPath, LowCodeApp.Designer.Properties.Resources.sqlite_sample);
                }
            }
        }
    }
}
