using System;
using Volo.Abp.Domain.Entities;

namespace DSSL.Blog.Comments
{
    public class Comment : Entity<Guid>
    {
        public string Message { get; set; }
        public Guid PostId { get; set; }

        private Comment() { }

        internal Comment(Guid id,
            string message,
            Guid postId) : base(id)
        {

        }
    }
}
