using DSSL.Blog.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DSSL.Blog.Controllers
{
    public abstract class BlogController : AbpControllerBase
    {
        protected BlogController()
        {
            LocalizationResource = typeof(BlogResource);
        }
    }
}