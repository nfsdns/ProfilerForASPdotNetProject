using Xunit;

namespace MyNewProject.EntityFrameworkCore;

[CollectionDefinition(MyNewProjectTestConsts.CollectionDefinitionName)]
public class MyNewProjectEntityFrameworkCoreCollection : ICollectionFixture<MyNewProjectEntityFrameworkCoreFixture>
{

}
