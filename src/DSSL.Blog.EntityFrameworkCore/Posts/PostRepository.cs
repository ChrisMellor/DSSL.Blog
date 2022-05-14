using Dssl.Blog.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Dssl.Blog.Posts
{
    public class PostRepository : EfCoreRepository<BlogDbContext, Post, Guid>, IPostRepository
    {
        public PostRepository(IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider) { }

        public async Task<ICollection<Post>> GetPostsAsync(bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            var postDbSet = await GetDbSetAsync();

            var posts = await postDbSet.Where(post => post.PublishDate.HasValue)
                .OrderByDescending(post => post.CreationTime)
                .ToListAsync(GetCancellationToken(cancellationToken));

            return posts;
        }

        public async Task<ICollection<Post>> GetPostsByOrderAsync(bool descending, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            var postDbSet = await GetDbSetAsync();

            var posts = await postDbSet.Where(post => post.PublishDate.HasValue)
                .OrderByDescending(post => post.CreationTime)
                .ToListAsync(GetCancellationToken(cancellationToken));

            return posts;
        }
    }
}
