using System;
using Volo.Abp.Application.Dtos;

namespace Dssl.Blog.Tags
{
    [Serializable]
    public class TagDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
