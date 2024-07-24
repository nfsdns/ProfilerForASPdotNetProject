using MyNewProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MyNewProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MyNewProjectEntityFrameworkCoreModule),
    typeof(MyNewProjectApplicationContractsModule)
    )]
public class MyNewProjectDbMigratorModule : AbpModule
{
}
