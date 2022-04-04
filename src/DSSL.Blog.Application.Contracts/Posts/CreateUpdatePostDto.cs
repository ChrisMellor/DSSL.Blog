using System;

namespace DSSL.Blog.Posts
{
    public class CreateUpdatePostDto
    {
        public string Title { get; set; }

        public string HeaderImage { get; set; }

        public string Tags { get; set; }

        public DateTime? PublishDate { get; set; }
    }
}
