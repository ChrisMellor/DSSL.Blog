using JetBrains.Annotations;
using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace DSSL.Blog.Authors
{
    public class Author : Entity<Guid>
    {
        public string Name { get; private set; }
        public Guid UserId { get; }

        private Author() { }

        internal Author(Guid id, [NotNull] string name) : base(id)
        {
            SetName(name);
        }

        internal Author ChangeName([NotNull] string name)
        {
            SetName(name);
            return this;
        }

        private void SetName([NotNull] string name)
        {
            Name = Check.NotNullOrWhiteSpace(name, nameof(name));
        }
    }
}
