using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Dssl.Blog.Tags
{
    public interface ITagRepository : IBasicRepository<Tag, Guid>
    {
        Task<ICollection<Tag>> GetTagsAsync(Guid postId, CancellationToken cancellationToken = default);
        Task<Tag> GetByNameAsync(string name, CancellationToken cancellationToken = default);
    }
}