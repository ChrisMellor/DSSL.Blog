using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Dssl.Blog.Posts
{
    public interface IPostRepository : IBasicRepository<Post, Guid>
    {
        Task<ICollection<Post>> GetPosts();
        Task<ICollection<Post>> GetPostsByOrder(bool descending);
    }
}