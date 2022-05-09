using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Dssl.Blog.Pages;

public class Index_Tests : BlogWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
