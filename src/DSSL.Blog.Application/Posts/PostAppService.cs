using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace DSSL.Blog.Posts
{
    public class PostAppService : ApplicationService
    {
        private readonly IRepository<Post, Guid> _postRepository;
        private readonly PostManager _postManager;

        public PostAppService(IRepository<Post, Guid> postRepository, PostManager postManager)
        {
            _postRepository = postRepository;
            _postManager = postManager;
        }

        public async Task<PostDto> CreateAsync(PostCreateDto input)
        {
            var post = await _postManager.CreateAsync(input.Title, input.HeaderImage, input.IsPublished, input.Tags);

            await _postRepository.InsertAsync(post);

            return ObjectMapper.Map<Post, PostDto>(post);
        }

        public async Task<PostDto> UpdateAsync(Guid id, PostDto input)
        {
            var post = await _postRepository.GetAsync(id);

            await _postManager.ChangeTitleAsync(post, input.Title);
            await _postManager.PublishAsync(post, input.IsPublished);
            await _postManager.ChangeHeaderImageAsync(post, input.HeaderImage);

            await _postRepository.UpdateAsync(post);

            return ObjectMapper.Map<Post, PostDto>(post);
        }

        public async Task<PostDto> GetAsync(Guid id)
        {
            var post = await _postRepository.GetAsync(id);

            return ObjectMapper.Map<Post, PostDto>(post);
        }
    }
}
