using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Dssl.Blog.Posts
{
    public interface IPostRepository : IBasicRepository<Post, Guid>
    {
        Task<ICollection<Post>> GetPostsAsync(bool includeDetails = false, CancellationToken cancellationToken = default);
        Task<ICollection<Post>> GetPostsByOrderAsync(bool descending, bool includeDetails = false, CancellationToken cancellationToken = default);
    }
}