using Dssl.Blog.Posts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dssl.Blog.Web.Pages
{
    public class IndexModel : BlogPageModel
    {
        private readonly PostAppService _postAppService;
        public IReadOnlyList<PostDto> Posts { get; set; }

        public IndexModel(PostAppService postAppService)
        {
            _postAppService = postAppService;
        }

        public async Task OnGetAsync()
        {
            Posts = await _postAppService.GetAllAsync();
        }
    }
}