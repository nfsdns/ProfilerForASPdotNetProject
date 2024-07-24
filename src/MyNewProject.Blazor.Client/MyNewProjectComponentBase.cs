using MyNewProject.Localization;
using Volo.Abp.AspNetCore.Components;

namespace MyNewProject.Blazor.Client;

public abstract class MyNewProjectComponentBase : AbpComponentBase
{
    protected MyNewProjectComponentBase()
    {
        LocalizationResource = typeof(MyNewProjectResource);
    }
}
