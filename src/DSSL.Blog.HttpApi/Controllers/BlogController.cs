using Dssl.Blog.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Dssl.Blog.Controllers
{
    public abstract class BlogController : AbpControllerBase
    {
        protected BlogController()
        {
            LocalizationResource = typeof(BlogResource);
        }
    }
}