using DSSL.Blog.Localization;
using Volo.Abp.Application.Services;

namespace DSSL.Blog
{
    public abstract class BlogAppService : ApplicationService
    {
        protected BlogAppService()
        {
            LocalizationResource = typeof(BlogResource);
        }
    }
}