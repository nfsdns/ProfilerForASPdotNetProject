using System.Threading.Tasks;

namespace MyNewProject.Data;

public interface IMyNewProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
