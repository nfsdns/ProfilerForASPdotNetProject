using Volo.Abp.Modularity;

namespace MyNewProject;

public abstract class MyNewProjectApplicationTestBase<TStartupModule> : MyNewProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
