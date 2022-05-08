using AutoMapper;
using DSSL.Blog.Posts;

namespace DSSL.Blog;

public class BlogApplicationAutoMapperProfile : Profile
{
    public BlogApplicationAutoMapperProfile()
    {
        CreateMap<Post, PostDto>();
        CreateMap<PostUpdateDto, Post>();
        CreateMap<PostCreateDto, PostDto>();
    }
}
