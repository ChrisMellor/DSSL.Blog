using DSSL.Blog.Comments;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DSSL.Blog.Web.Pages.Comments
{
    public class EditModalModel : BlogPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CommentUpdateDto Comment { get; set; }

        private readonly CommentAppService _commentAppService;

        public EditModalModel(CommentAppService commentAppService)
        {
            _commentAppService = commentAppService;
        }

        public async Task OnGetAsync()
        {
            var commentDto = await _commentAppService.GetAsync(Id);
            Comment = ObjectMapper.Map<CommentDto, CommentUpdateDto>(commentDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _commentAppService.UpdateAsync(Id, Comment);
            return NoContent();
        }
    }
}
