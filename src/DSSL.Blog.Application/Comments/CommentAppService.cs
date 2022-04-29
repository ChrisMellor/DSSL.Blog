using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace DSSL.Blog.Comments
{
    public class CommentAppService : CrudAppService<Comment, CommentDto, Guid, PagedAndSortedResultRequestDto, CommentUpdateDto>, ICommentAppService
    {
        public CommentAppService(IRepository<Comment, Guid> repository) : base(repository) { }
    }
}
