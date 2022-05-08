using DSSL.Blog.Comments;
using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace DSSL.Blog.Posts
{
    [Serializable]
    public class PostDto : AuditedEntityDto<Guid>
    {
        public string Title { get; set; }
        public string HeaderImage { get; set; }
        public DateTime? PublishDate { get; set; }
        public bool IsPublished => PublishDate.HasValue;
        public ICollection<string> Tags { get; set; }
        public ICollection<CommentDto> Comments { get; set; }
    }
}
