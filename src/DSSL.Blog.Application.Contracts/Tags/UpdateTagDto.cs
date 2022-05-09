using System;
using Volo.Abp.Application.Dtos;

namespace Dssl.Blog.Tags
{
    [Serializable]
    public class UpdateTagDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
