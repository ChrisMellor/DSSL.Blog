using Volo.Abp.Modularity;

namespace DSSL.Blog;

[DependsOn(
    typeof(BlogApplicationModule),
    typeof(BlogDomainTestModule)
    )]
public class BlogApplicationTestModule : AbpModule
{

}
