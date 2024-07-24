using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MyNewProject.Web;

[Dependency(ReplaceServices = true)]
public class MyNewProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MyNewProject";
}
