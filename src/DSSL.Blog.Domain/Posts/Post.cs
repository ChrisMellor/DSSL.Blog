using System;
using System.Collections.Generic;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace DSSL.Blog.Posts
{
    public class Post : FullAuditedAggregateRoot<Guid>
    {
        public string Title { get; protected set; }
        public string Message { get; set; }
        public string HeaderImage { get; protected set; }
        public DateTime? PublishDate { get; protected set; }
        public ICollection<string> Tags { get; protected set; }

        public Post(
            Guid id,
            string title,
            string message,
            string headerImage,
            bool isPublished,
            ICollection<string> tags) : base(id)
        {
            Title = Check.NotNullOrWhiteSpace(title, nameof(title));
            Message = Check.NotNullOrWhiteSpace(message, nameof(message));
            HeaderImage = headerImage;
            PublishDate = isPublished ? DateTime.UtcNow : null;
            Tags = tags;
        }

        protected Post() { }

        internal void SetTitle(string title)
        {
            Title = Check.NotNullOrWhiteSpace(title, nameof(title));
        }

        internal void SetMessage(string message)
        {
            Message = Check.NotNullOrWhiteSpace(message, nameof(message));
        }

        internal void SetHeaderImage(string headerImage)
        {
            HeaderImage = Check.NotNullOrWhiteSpace(headerImage, nameof(headerImage));
        }

        internal void Publish()
        {
            if (PublishDate.HasValue)
            {
                throw new PublishedException("Posts:IsPublishedException");
            }

            PublishDate = DateTime.UtcNow;
        }
    }
}