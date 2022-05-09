using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace Dssl.Blog.Posts
{
    public class PostManager : DomainService
    {
        public async Task<Post> CreateAsync(string title, string message, string headerImage, bool isPublished, ICollection<string> tags)
        {
            return new Post(GuidGenerator.Create(), title, message, headerImage, isPublished);
        }

        public async Task ChangeTitleAsync(Post post, string title)
        {
            if (post.Title == title)
            {
                return;
            }

            post.SetTitle(title);
        }

        public async Task ChangeMessageAsync(Post post, string message)
        {
            if (post.Message == message)
            {
                return;
            }

            post.SetMessage(message);
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