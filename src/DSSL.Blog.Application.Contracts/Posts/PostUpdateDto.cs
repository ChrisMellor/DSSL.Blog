using System;
using System.Collections.Generic;

namespace DSSL.Blog.Posts
{
    [Serializable]
    public class PostUpdateDto
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string HeaderImage { get; set; }
        private DateTime? PublishDate { get; set; }
        public bool IsPublished => PublishDate.HasValue;
        public ICollection<string> Tags { get; set; }
    }
}