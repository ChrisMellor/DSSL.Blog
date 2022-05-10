using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Dssl.Blog.Tags
{
    public class TagRepository : ITagRepository
    {
        public async Task<List<Tag>> GetListAsync(bool includeDetails = false, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task<long> GetCountAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task<List<Tag>> GetPagedListAsync(int skipCount, int maxResultCount, string sorting, bool includeDetails = false,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task<Tag> InsertAsync(Tag entity, bool autoSave = false, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task InsertManyAsync(IEnumerable<Tag> entities, bool autoSave = false,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task<Tag> UpdateAsync(Tag entity, bool autoSave = false, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task UpdateManyAsync(IEnumerable<Tag> entities, bool autoSave = false,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Tag entity, bool autoSave = false, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task DeleteManyAsync(IEnumerable<Tag> entities, bool autoSave = false,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task<Tag> GetAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        public async Task<Tag> FindAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = new CancellationToken())
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

        public async Task<ICollection<TagDto>> GetTagsAsync(Guid postId)
        {
            throw new NotImplementedException();
        }

        public async Task<Tag> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
