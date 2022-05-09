using System;
using Volo.Abp.Application.Dtos;

namespace Dssl.Blog.Posts
{
    [Serializable]
    public class PostDto : EntityDto<Guid>
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string HeaderImage { get; set; }
        public DateTime? PublishDate { get; set; }
    }
}