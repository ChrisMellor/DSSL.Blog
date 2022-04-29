using DSSL.Blog.Comments;
using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace DSSL.Blog.Posts
{
    [Serializable]
    public class PostUpdateDto : AuditedEntityDto<Guid>
    {
        public Guid AuthorId { get; set; }
        public string Title { get; set; }
        public string HeaderImage { get; set; }
        private DateTime? PublishDate { get; set; }
        public bool IsPublished => PublishDate.HasValue;
        public ICollection<string> Tags { get; set; }
        public ICollection<CommentDto> Comments { get; set; }
    }
}
