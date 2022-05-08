using System;
using Volo.Abp.Domain.Entities;

namespace DSSL.Blog.Comments
{
    public class Comment : Entity<Guid>
    {
        public string Message { get; set; }
        public Guid PostId { get; set; }

        internal Comment(Guid id, string message, Guid postId) : base(id)
        {
            Message = message;
            PostId = postId;
        }

        private Comment() { }
    }
}
