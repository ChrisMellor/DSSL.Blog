using Dssl.Blog.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;

namespace Dssl.Blog.Tags
{
    public class TagRepository : EfCoreRepository<BlogDbContext, Tag, Guid>, ITagRepository
    {
        public TagRepository(Volo.Abp.EntityFrameworkCore.IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider) { }

        public async Task<Tag> GetByNameAsync(string name, CancellationToken cancellationToken = default)
        {
            var tagDbSet = await GetDbSetAsync();

            var tags = await tagDbSet.SingleOrDefaultAsync(x => x.Name == name, GetCancellationToken(cancellationToken));

            return tags;
        }

        public async Task<ICollection<Tag>> GetTagsAsync(Guid postId, CancellationToken cancellationToken = default)
        {
            var tagDbSet = await GetDbSetAsync();

            var tags = await tagDbSet.ToListAsync(GetCancellationToken(cancellationToken));

            return tags;
        }
    }
}
