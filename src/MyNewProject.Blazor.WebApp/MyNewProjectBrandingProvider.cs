using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MyNewProject.Blazor.WebApp;

[Dependency(ReplaceServices = true)]
public class MyNewProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MyNewProject";
}
