using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace DSSL.Blog.Posts
{
    [Serializable]
    public class PostCreateDto : AuditedEntityDto<Guid>
    {
        public string Title { get; set; }
        public string HeaderImage { get; set; }
        public bool IsPublished { get; set; }
        public ICollection<string> Tags { get; set; }
    }
}