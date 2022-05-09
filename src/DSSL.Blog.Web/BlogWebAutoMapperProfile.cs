using AutoMapper;
using Dssl.Blog.Posts;

namespace Dssl.Blog.Web
{
    public class BlogWebAutoMapperProfile : Profile
    {
        public BlogWebAutoMapperProfile()
        {
            CreateMap<PostDto, PostUpdateDto>();
        }
    }
}