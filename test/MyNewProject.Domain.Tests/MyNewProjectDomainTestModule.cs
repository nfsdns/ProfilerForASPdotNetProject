using Volo.Abp.Modularity;

namespace MyNewProject;

[DependsOn(
    typeof(MyNewProjectDomainModule),
    typeof(MyNewProjectTestBaseModule)
)]
public class MyNewProjectDomainTestModule : AbpModule
{

}
