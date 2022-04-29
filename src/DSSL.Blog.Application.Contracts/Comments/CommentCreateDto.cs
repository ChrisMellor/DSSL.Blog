using System;
using Volo.Abp.Application.Dtos;

namespace DSSL.Blog.Comments
{
    public class CommentCreateDto : EntityDto<Guid>
    {
        public string Message { get; set; }
    }
}
