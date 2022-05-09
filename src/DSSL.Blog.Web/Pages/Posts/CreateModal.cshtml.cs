using Dssl.Blog.Posts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Dssl.Blog.Web.Pages.Posts
{
    public class CreateModalModel : BlogPageModel
    {
        [BindProperty]
        public PostCreateDto Post { get; set; }

        private readonly PostAppService _postAppService;

        public CreateModalModel(PostAppService postAppService)
        {
            _postAppService = postAppService;
        }

        public void OnGet()
        {
            Post = new PostCreateDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _postAppService.CreateAsync(Post);
            return NoContent();
        }
    }
}
