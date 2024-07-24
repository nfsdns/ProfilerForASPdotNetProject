using MyNewProject.Samples;
using Xunit;

namespace MyNewProject.EntityFrameworkCore.Applications;

[Collection(MyNewProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MyNewProjectEntityFrameworkCoreTestModule>
{

}
