using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MyNewProject.Blazor.WebApp.Tiered;

[Dependency(ReplaceServices = true)]
public class MyNewProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MyNewProject";
}
