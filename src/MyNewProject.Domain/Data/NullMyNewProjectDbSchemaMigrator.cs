using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MyNewProject.Data;

/* This is used if database provider does't define
 * IMyNewProjectDbSchemaMigrator implementation.
 */
public class NullMyNewProjectDbSchemaMigrator : IMyNewProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
