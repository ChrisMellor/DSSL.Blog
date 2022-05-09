using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DSSL.Blog.Web
{
    [Dependency(ReplaceServices = true)]
    public class BlogBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Blog";
    }
}