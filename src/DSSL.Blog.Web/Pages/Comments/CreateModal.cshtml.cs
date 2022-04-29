using DSSL.Blog.Comments;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DSSL.Blog.Web.Pages.Comments
{
    public class CreateModalModel : BlogPageModel
    {
        [BindProperty]
        public CommentUpdateDto Comment { get; set; }

        private readonly CommentAppService _commentAppService;

        public CreateModalModel(CommentAppService commentAppService)
        {
            _commentAppService = commentAppService;
        }

        public void OnGet()
        {
            Comment = new CommentUpdateDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _commentAppService.CreateAsync(Comment);
            return NoContent();
        }
    }
}
