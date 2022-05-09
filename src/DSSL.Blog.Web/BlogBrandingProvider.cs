using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Dssl.Blog.Web
{
    [Dependency(ReplaceServices = true)]
    public class BlogBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Blog";
    }
}