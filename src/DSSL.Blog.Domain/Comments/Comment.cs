using System;
using Volo.Abp.Domain.Entities;

namespace DSSL.Blog.Comments
{
    public class Comment : Entity<Guid>
    {
        public string Message { get; set; }
        public virtual Guid PostId { get; protected set; }

        internal Comment(Guid id, string message, Guid postId) : base(id)
        {
            Message = message;
            PostId = postId;
        }

        protected Comment() { }
    }
}
