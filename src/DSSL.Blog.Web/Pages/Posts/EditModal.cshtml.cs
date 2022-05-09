using Dssl.Blog.Posts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Dssl.Blog.Web.Pages.Posts
{
    public class EditModalModel : BlogPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public UpdatePostDto UpdatePost { get; set; }

        private readonly PostAppService _postAppService;

        public EditModalModel(PostAppService postAppService)
        {
            _postAppService = postAppService;
        }

        public async Task OnGetAsync()
        {
            var postDto = await _postAppService.GetAsync(Id);
            UpdatePost = ObjectMapper.Map<PostDto, UpdatePostDto>(postDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _postAppService.UpdateAsync(Id, UpdatePost);
            return NoContent();
        }
    }
}
