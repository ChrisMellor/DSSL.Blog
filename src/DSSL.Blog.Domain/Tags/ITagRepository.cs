using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Dssl.Blog.Tags
{
    public interface ITagRepository : IBasicRepository<Tag, Guid>
    {
        Task<ICollection<Tag>> GetTagsAsync();
        Task<Tag> GetByNameAsync(string name);
    }
}