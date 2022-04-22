using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DSSL.Blog.Web;

[Dependency(ReplaceServices = true)]
public class BlogBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Blog";
    public override string LogoUrl => "https://community.abp.io/assets/svg/abp-logo.svg";
    public override string LogoReverseUrl => "https://community.abp.io/assets/svg/abp-logo.svg";
}
