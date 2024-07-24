using MyNewProject.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MyNewProject.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class MyNewProjectPageModel : AbpPageModel
{
    protected MyNewProjectPageModel()
    {
        LocalizationResourceType = typeof(MyNewProjectResource);
    }
}
