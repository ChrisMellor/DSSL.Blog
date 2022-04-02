using System;
using Volo.Abp.Domain.Entities;

namespace DSSL.Blog.Authors
{
    public class Author : Entity<Guid>
    {
        public Guid UserId { get; }

        private Author() { }

        internal Author(Guid id, Guid userId) : base(id)
        {
            UserId = userId;
        }
    }
}
