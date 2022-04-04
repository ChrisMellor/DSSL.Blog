using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace DSSL.Blog.Posts
{
    public interface IPostAppService : ICrudAppService<PostDto, Guid, PagedAndSortedResultRequestDto, CreateUpdatePostDto> { }
}
