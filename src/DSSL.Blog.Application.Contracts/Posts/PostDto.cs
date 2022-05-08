using System;
using Volo.Abp.Application.Dtos;

namespace DSSL.Blog.Posts
{
    [Serializable]
    public class PostDto : FullAuditedEntityDto<Guid>
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string HeaderImage { get; set; }
        public DateTime? PublishDate { get; set; }
    }
}
