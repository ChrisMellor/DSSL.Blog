using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Dssl.Blog.Tags
{
    public class Tag : AggregateRoot<Guid>
    {
        public string Name { get; protected set; }

        public Tag(Guid id, string name) : base(id)
        {
            Name = Check.NotNullOrWhiteSpace(name, nameof(Name));
        }

        protected Tag() { }

        public virtual void ChangeName(string name)
        {
            Name = Check.NotNullOrWhiteSpace(name, nameof(Name));
        }
    }
}