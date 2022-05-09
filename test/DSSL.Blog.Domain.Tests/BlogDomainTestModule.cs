using Dssl.Blog.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Dssl.Blog;

[DependsOn(
    typeof(BlogEntityFrameworkCoreTestModule)
    )]
public class BlogDomainTestModule : AbpModule
{

}
