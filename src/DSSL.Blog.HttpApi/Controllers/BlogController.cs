using DSSL.Blog.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DSSL.Blog.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BlogController : AbpControllerBase
{
    protected BlogController()
    {
        LocalizationResource = typeof(BlogResource);
    }
}
