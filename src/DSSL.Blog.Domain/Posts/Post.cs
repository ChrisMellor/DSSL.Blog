using DSSL.Blog.Comments;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace DSSL.Blog.Posts
{
    public class Post : AggregateRoot<Guid>
    {
        public Guid AuthorId { get; init; }
        public string Title { get; private set; }
        public string HeaderImage { get; private set; }
        public DateTime? PublishDate { get; private set; }
        public bool IsPublished => PublishDate.HasValue;

        public ICollection<string> Tags { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public Post(
            Guid id,
            Guid authorId,
            string title,
            string headerImage,
            bool isPublished,
            ICollection<string> tags) : base(id)
        {
            AuthorId = authorId;
            Title = Check.NotNullOrWhiteSpace(title, nameof(title));
            HeaderImage = headerImage;
            PublishDate = isPublished ? DateTime.UtcNow : null;
            Tags = tags;
            Comments = new Collection<Comment>();
        }

        private Post() { }

        internal void SetTitle(string title)
        {
            Title = Check.NotNullOrWhiteSpace(title, nameof(title));
        }

        internal void SetHeaderImage(string headerImage)
        {
            HeaderImage = Check.NotNullOrWhiteSpace(headerImage, nameof(headerImage));
        }

        internal void Publish()
        {
            if (IsPublished)
            {
                throw new PublishedException("Posts:IsPublishedException");
            }

            PublishDate = DateTime.UtcNow;
        }
    }
}
