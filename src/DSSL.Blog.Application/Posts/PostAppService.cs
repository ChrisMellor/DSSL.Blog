using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace DSSL.Blog.Posts
{
    public class PostAppService : CrudAppService<Post, PostDto, Guid, PagedAndSortedResultRequestDto, CreateUpdatePostDto>, IPostAppService
    {
        public PostAppService(IRepository<Post, Guid> repository) : base(repository)
        {

        }

    }
}
