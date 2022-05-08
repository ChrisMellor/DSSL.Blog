using AutoMapper;
using DSSL.Blog.Comments;
using DSSL.Blog.Posts;
using System.Collections.Generic;

namespace DSSL.Blog;

public class BlogApplicationAutoMapperProfile : Profile
{
    public BlogApplicationAutoMapperProfile()
    {
        CreateMap<Post, PostDto>();
        CreateMap<PostUpdateDto, Post>();
        CreateMap<PostCreateDto, PostDto>();

        CreateMap<Comment, CommentDto>();
        CreateMap<CommentCreateDto, CommentDto>();
    }
}
