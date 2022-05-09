using Dssl.Blog.Localization;
using Volo.Abp.Application.Services;

namespace Dssl.Blog
{
    public abstract class BlogAppService : ApplicationService
    {
        protected BlogAppService()
        {
            LocalizationResource = typeof(BlogResource);
        }
    }
}