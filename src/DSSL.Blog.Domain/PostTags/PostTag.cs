using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Values;

namespace Dssl.Blog.PostTags
{
    public class PostTag : ValueObject
    {
        public Guid PostId { get; protected set; }
        public Guid TagId { get; protected set; }

        public PostTag(Guid postId, Guid tagId)
        {
            PostId = postId;
            TagId = tagId;
        }

        protected PostTag() { }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return PostId;
            yield return TagId;
        }
    }
}