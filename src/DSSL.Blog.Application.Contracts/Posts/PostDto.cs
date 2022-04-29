using DSSL.Blog.Comments;
using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace DSSL.Blog.Posts
{
    [Serializable]
    public class PostDto : AuditedEntityDto<Guid>
    {
        public Guid AuthorId { get; }
        public string Title { get; }
        public string HeaderImage { get; }
        public bool IsPublished { get; set; }
        public ICollection<string> Tags { get; }
        public ICollection<CommentDto> Comments { get; }
    }
}
