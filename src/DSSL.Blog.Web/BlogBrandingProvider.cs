using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace DSSL.Blog.Web;

[Dependency(ReplaceServices = true)]
public class BlogBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Blog";
}
