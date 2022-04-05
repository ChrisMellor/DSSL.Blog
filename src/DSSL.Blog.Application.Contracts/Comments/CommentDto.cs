using System;
using Volo.Abp.Application.Dtos;

namespace DSSL.Blog.Comments
{
    public class CommentDto : AuditedEntityDto<Guid>
    {
        public string Title { get; set; }

        public string HeaderImage { get; set; }

        public string Tags { get; set; }

        public bool IsPublished { get; set; }

        public Guid AuthorId { get; set; }
    }
}
