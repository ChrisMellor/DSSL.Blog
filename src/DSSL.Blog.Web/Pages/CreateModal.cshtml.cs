using DSSL.Blog.Posts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DSSL.Blog.Web.Pages
{
    public class CreateModalModel : BlogPageModel
    {
        [BindProperty]
        public CreateUpdatePostDto Post { get; set; }

        private readonly IPostAppService _postAppService;

        public CreateModalModel(IPostAppService postAppService)
        {
            _postAppService = postAppService;
        }

        public void OnGet()
        {
            Post = new CreateUpdatePostDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _postAppService.CreateAsync(Post);
            return NoContent();
        }
    }
}
