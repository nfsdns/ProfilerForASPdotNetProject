using Microsoft.AspNetCore.Builder;
using MyNewProject;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<MyNewProjectWebTestModule>();

public partial class Program
{
}
