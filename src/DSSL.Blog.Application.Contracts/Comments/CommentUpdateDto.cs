using System;
using Volo.Abp.Application.Dtos;

namespace DSSL.Blog.Comments
{
    public class CommentUpdateDto : EntityDto<Guid>
    {
        public string Message { get; set; }
    }
}
