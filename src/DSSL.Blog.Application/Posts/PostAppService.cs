using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Data;
using Volo.Abp.Domain.Repositories;

namespace DSSL.Blog.Posts
{
    public class PostAppService : ApplicationService
    {
        private readonly IRepository<Post, Guid> _postRepository;
        private readonly PostManager _postManager;
        private readonly IDataFilter _dataFilter;

        public PostAppService(IRepository<Post, Guid> postRepository, PostManager postManager, IDataFilter dataFilter)
        {
            _postRepository = postRepository;
            _postManager = postManager;
            _dataFilter = dataFilter;
        }

        public async Task<PostDto> CreateAsync(PostCreateDto input)
        {
            var post = await _postManager.CreateAsync(input.Title, input.HeaderImage, input.IsPublished, input.Tags);

            await _postRepository.InsertAsync(post);

            return ObjectMapper.Map<Post, PostDto>(post);
        }

        public async Task<PostDto> UpdateAsync(Guid id, PostUpdateDto input)
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

            var postDto = ObjectMapper.Map<Post, PostDto>(post);

            return postDto;
        }

        public async Task<List<PostDto>> GetAllAsync()
        {
            var post = await _postRepository.GetListAsync();

            var postDtos = ObjectMapper.Map<List<Post>, List<PostDto>>(post);

            return postDtos;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _postRepository.DeleteAsync(id);
        }

        public async Task RestoreAsync(Guid id)
        {
            using (_dataFilter.Disable<ISoftDelete>())
            {
                var post = await _postRepository.GetAsync(id);
            }
        }
    }
}
