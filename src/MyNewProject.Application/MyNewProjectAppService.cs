using System;
using System.Collections.Generic;
using System.Text;
using MyNewProject.Localization;
using Volo.Abp.Application.Services;

namespace MyNewProject;

/* Inherit your application services from this class.
 */
public abstract class MyNewProjectAppService : ApplicationService
{
    protected MyNewProjectAppService()
    {
        LocalizationResource = typeof(MyNewProjectResource);
    }
}
