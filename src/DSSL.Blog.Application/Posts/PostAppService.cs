using Dssl.Blog.Tags;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;

namespace Dssl.Blog.Posts
{
    public class PostAppService : ApplicationService
    {
        private readonly IPostRepository _postRepository;
        private readonly ITagRepository _tagRepository;
        private readonly PostManager _postManager;

        public PostAppService(IPostRepository postRepository, ITagRepository tagRepository, PostManager postManager)
        {
            _postRepository = postRepository;
            _tagRepository = tagRepository;
            _postManager = postManager;
        }

        public async Task<PostDto> CreateAsync(CreatePostDto input)
        {
            var post = await _postManager.CreateAsync(input.Title, input.Message, input.HeaderImage, input.IsPublished, input.Tags);

            await _postRepository.InsertAsync(post);

            return ObjectMapper.Map<Post, PostDto>(post);
        }

        public async Task<PostDto> UpdateAsync(Guid id, UpdatePostDto input)
        {
            var post = await _postRepository.GetAsync(id);

            await _postManager.ChangeTitleAsync(post, input.Title);
            await _postManager.ChangeMessageAsync(post, input.Message);
            await _postManager.PublishAsync(post, input.HasPublished);
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
            var posts = await _postRepository.GetPostsAsync();
            var postDtos = new List<PostDto>(ObjectMapper.Map<ICollection<Post>, ICollection<PostDto>>(posts));

            //foreach (var postDto in postDtos)
            //{
            //    postDto.Tags = await _tagRepository.GetTagsAsync(postDto.Id);
            //}

            return postDtos;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _postRepository.DeleteAsync(id);
        }

        public async Task RestoreAsync(Guid id)
        {
            using (DataFilter.Disable<ISoftDelete>())
            {
                var post = await _postRepository.GetAsync(id);
                await _postManager.RestoreAsync(post);
                await _postRepository.UpdateAsync(post);
            }
        }
    }
}