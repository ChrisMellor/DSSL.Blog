using DSSL.Blog.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DSSL.Blog;

[DependsOn(
    typeof(BlogEntityFrameworkCoreTestModule)
    )]
public class BlogDomainTestModule : AbpModule
{

}
