using Dssl.Blog.PostTags;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Dssl.Blog.Posts
{
    public class Post : FullAuditedAggregateRoot<Guid>
    {
        public string Title { get; protected set; }
        public string Message { get; set; }
        public string HeaderImage { get; protected set; }
        public DateTime? PublishDate { get; protected set; }
        public virtual ICollection<PostTag> Tags { get; protected set; }

        public Post(
            Guid id,
            string title,
            string message,
            string headerImage,
            bool isPublished) : base(id)
        {
            Title = Check.NotNullOrWhiteSpace(title, nameof(title));
            Message = Check.NotNullOrWhiteSpace(message, nameof(message));
            HeaderImage = headerImage;
            PublishDate = isPublished ? DateTime.UtcNow : null;
            Tags = new Collection<PostTag>();
        }

        protected Post() { }

        internal Post SetTitle(string title)
        {
            Title = Check.NotNullOrWhiteSpace(title, nameof(title));
            return this;
        }

        internal Post SetMessage(string message)
        {
            Message = Check.NotNullOrWhiteSpace(message, nameof(message));
            return this;
        }

        internal Post SetHeaderImage(string headerImage)
        {
            HeaderImage = Check.NotNullOrWhiteSpace(headerImage, nameof(headerImage));
            return this;
        }

        internal Post Publish()
        {
            if (PublishDate.HasValue)
            {
                throw new PublishedException("Posts:IsPublishedException");
            }

            PublishDate = DateTime.UtcNow;
            return this;
        }

        internal void AddTag(Guid tagId)
        {
            Tags.Add(new PostTag(Id, tagId));
        }

        internal void RemoveTag(Guid tagId)
        {
            Tags.RemoveAll(x => x.TagId == tagId);
        }
    }
}