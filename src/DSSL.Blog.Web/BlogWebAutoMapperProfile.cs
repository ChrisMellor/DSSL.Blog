using AutoMapper;
using Dssl.Blog.Posts;
using Dssl.Blog.Tags;

namespace Dssl.Blog.Web
{
    public class BlogWebAutoMapperProfile : Profile
    {
        public BlogWebAutoMapperProfile()
        {
            CreateMap<PostDto, UpdatePostDto>();
            CreateMap<Tag, TagDto>();
        }
    }
}