using System.Collections.Generic;

namespace DSSL.Blog.Posts;

public class PostCreateDto
{
    public string Title { get; set; }
    public string HeaderImage { get; set; }
    public bool IsPublished { get; set; }
    public ICollection<string> Tags { get; set; }
}