using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace DSSL.Blog.Comments
{
    public class CommentManager : DomainService
    {
        public async Task<Comment> CreateAsync(string message, Guid postId)
        {
            return new Comment(GuidGenerator.Create(), message, postId);
        }
    }
}
