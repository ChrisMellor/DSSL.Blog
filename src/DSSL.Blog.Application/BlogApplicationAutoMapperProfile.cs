using AutoMapper;
using Dssl.Blog.Posts;

namespace Dssl.Blog
{
    public class BlogApplicationAutoMapperProfile : Profile
    {
        public BlogApplicationAutoMapperProfile()
        {
            CreateMap<Post, PostDto>();
            CreateMap<UpdatePostDto, Post>();
            CreateMap<CreatePostDto, PostDto>();
        }
    }
}