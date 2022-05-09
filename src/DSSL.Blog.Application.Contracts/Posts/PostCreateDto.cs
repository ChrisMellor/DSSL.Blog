using System;
using System.Collections.Generic;

namespace Dssl.Blog.Posts
{
    [Serializable]
    public class PostCreateDto
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string HeaderImage { get; set; }
        public bool IsPublished { get; set; }
        public ICollection<string> Tags { get; set; }
    }
}