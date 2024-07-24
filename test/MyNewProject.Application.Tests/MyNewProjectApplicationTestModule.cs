using Volo.Abp.Modularity;

namespace MyNewProject;

[DependsOn(
    typeof(MyNewProjectApplicationModule),
    typeof(MyNewProjectDomainTestModule)
)]
public class MyNewProjectApplicationTestModule : AbpModule
{

}
