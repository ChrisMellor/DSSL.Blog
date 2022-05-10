using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Dssl.Blog.Posts
{
    public class PostRepository : IPostRepository
    {
        public async Task<List<Post>> GetListAsync(bool includeDetails = false, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task<long> GetCountAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task<List<Post>> GetPagedListAsync(int skipCount, int maxResultCount, string sorting, bool includeDetails = false,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task<Post> InsertAsync(Post entity, bool autoSave = false, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task InsertManyAsync(IEnumerable<Post> entities, bool autoSave = false,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task<Post> UpdateAsync(Post entity, bool autoSave = false, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task UpdateManyAsync(IEnumerable<Post> entities, bool autoSave = false,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Post entity, bool autoSave = false, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task DeleteManyAsync(IEnumerable<Post> entities, bool autoSave = false,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task<Post> GetAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task<Post> FindAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Guid id, bool autoSave = false, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task DeleteManyAsync(IEnumerable<Guid> ids, bool autoSave = false,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Post>> GetPosts()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Post>> GetPostsByOrder(bool @descending)
        {
            throw new NotImplementedException();
        }
    }
}
