using AutoMapper;
using DSSL.Blog.Posts;

namespace DSSL.Blog.Web;

public class BlogWebAutoMapperProfile : Profile
{
    public BlogWebAutoMapperProfile()
    {
        CreateMap<PostDto, CreateUpdatePostDto>();
    }
}
