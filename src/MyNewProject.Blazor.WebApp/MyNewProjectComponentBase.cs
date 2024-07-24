using MyNewProject.Localization;
using Volo.Abp.AspNetCore.Components;

namespace MyNewProject.Blazor.WebApp;

public abstract class MyNewProjectComponentBase : AbpComponentBase
{
    protected MyNewProjectComponentBase()
    {
        LocalizationResource = typeof(MyNewProjectResource);
    }
}
