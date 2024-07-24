using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyNewProject.Data;
using Volo.Abp.DependencyInjection;

namespace MyNewProject.EntityFrameworkCore;

public class EntityFrameworkCoreMyNewProjectDbSchemaMigrator
    : IMyNewProjectDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMyNewProjectDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the MyNewProjectDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MyNewProjectDbContext>()
            .Database
            .MigrateAsync();
    }
}
