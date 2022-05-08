using System;

namespace DSSL.Blog.Comments
{
    public class CommentCreateDto
    {
        public string Message { get; set; }
        public Guid PostId { get; set; }
    }
}
