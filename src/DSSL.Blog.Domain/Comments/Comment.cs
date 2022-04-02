using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace DSSL.Blog.Comments
{
    public class Comment : AuditedAggregateRoot<Guid>
    {
        public string Message { get; set; }
        public Guid PostId { get; set; }
    }
}
