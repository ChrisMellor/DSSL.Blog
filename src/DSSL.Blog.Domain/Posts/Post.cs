using System;
using Volo.Abp.Domain.Entities;

namespace DSSL.Blog.Posts
{
    public class Post : Entity<Guid>
    {
        public string Title { get; set; }
        public DateTime? PublishDate { get; set; }
        public Guid AuthorId { get; init; }
        public bool IsPublished => PublishDate.HasValue;
        public string HeaderImage { get; set; }
        public string Tags { get; set; }

        private Post() { }
        internal Post(Guid id) : base(id) { }

    }
}
