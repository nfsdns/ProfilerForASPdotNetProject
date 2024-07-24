using Volo.Abp.Modularity;

namespace MyNewProject;

/* Inherit from this class for your domain layer tests. */
public abstract class MyNewProjectDomainTestBase<TStartupModule> : MyNewProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
