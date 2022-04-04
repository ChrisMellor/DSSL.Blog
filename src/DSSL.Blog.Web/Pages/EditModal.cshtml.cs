using DSSL.Blog.Posts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DSSL.Blog.Web.Pages
{
    public class EditModalModel : BlogPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdatePostDto Post { get; set; }

        private readonly IPostAppService _postAppService;

        public EditModalModel(IPostAppService postAppService)
        {
            _postAppService = postAppService;
        }

        public async Task OnGetAsync()
        {
            var postDto = await _postAppService.GetAsync(Id);
            Post = ObjectMapper.Map<PostDto, CreateUpdatePostDto>(postDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _postAppService.UpdateAsync(Id, Post);
            return NoContent();
        }
    }
}
