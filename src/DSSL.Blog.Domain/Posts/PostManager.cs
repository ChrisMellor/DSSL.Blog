using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace DSSL.Blog.Posts
{
    public class PostManager : DomainService
    {
        public async Task<Post> CreateAsync(string title, string headerImage, bool isPublished, ICollection<string> tags)
        {
            return new Post(GuidGenerator.Create(), title, headerImage, isPublished, tags);
        }

        public async Task ChangeTitleAsync(Post post, string title)
        {
            if (post.Title == title)
            {
                return;
            }

            post.SetTitle(title);
        }

        public async Task PublishAsync(Post post, bool isPublished)
        {
            if (isPublished)
            {
                post.Publish();
            }
        }

        public async Task ChangeHeaderImageAsync(Post post, string headerImage)
        {
            if (post.HeaderImage == headerImage)
            {
                return;
            }

            post.SetHeaderImage(headerImage);
        }
    }
}
