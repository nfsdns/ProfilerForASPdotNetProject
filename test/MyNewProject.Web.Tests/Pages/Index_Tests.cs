using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MyNewProject.Pages;

public class Index_Tests : MyNewProjectWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
