using MyNewProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyNewProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MyNewProjectController : AbpControllerBase
{
    protected MyNewProjectController()
    {
        LocalizationResource = typeof(MyNewProjectResource);
    }
}
