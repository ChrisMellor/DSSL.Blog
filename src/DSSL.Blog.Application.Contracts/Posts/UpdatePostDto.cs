using System;
using Volo.Abp.Application.Dtos;

namespace Dssl.Blog.Posts
{
    [Serializable]
    public class UpdatePostDto : EntityDto<Guid>
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string HeaderImage { get; set; }
        private bool HasPublished { get; set; }
    }
}