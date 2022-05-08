using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace DSSL.Blog.Comments
{
    public class CommentAppService : ApplicationService
    {
        private readonly IRepository<Comment, Guid> _commentRepository;
        private readonly CommentManager _commentManager;
        public CommentAppService(IRepository<Comment, Guid> commentRepository, CommentManager commentManager)
        {
            _commentRepository = commentRepository;
            _commentManager = commentManager;
        }

        public async Task<CommentDto> CreateAsync(CommentCreateDto input)
        {
            var comment = await _commentManager.CreateAsync(input.Message, input.PostId);

            await _commentRepository.InsertAsync(comment);

            return ObjectMapper.Map<Comment, CommentDto>(comment);
        }
    }
}
