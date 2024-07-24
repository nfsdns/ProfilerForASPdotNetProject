using MyNewProject.Samples;
using Xunit;

namespace MyNewProject.EntityFrameworkCore.Domains;

[Collection(MyNewProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MyNewProjectEntityFrameworkCoreTestModule>
{

}
