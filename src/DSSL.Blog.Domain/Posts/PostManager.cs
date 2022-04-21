using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp.Users;

namespace DSSL.Blog.Posts
{
    public class PostManager : DomainService
    {
        private readonly ICurrentUser _currentUser;

        public PostManager(IRepository<Post> postRepository, ICurrentUser currentUser)
        {
            _currentUser = currentUser;
        }

        public async Task<Post> CreateAsync(string title, string headerImage, bool isPublished, ICollection<string> tags)
        {
            var authorId = _currentUser.GetId();

            return new Post(GuidGenerator.Create(), authorId, title, headerImage, isPublished, tags);
        }

        public async Task ChangeTitleAsync(Post post, string title)
        {
            if (post.Title == title)
            {
                return;
            }

            post.SetTitle(title);
        }
    }
}
