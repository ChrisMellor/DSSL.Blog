using DSSL.Blog.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace DSSL.Blog.Authors
{
    internal class AuthorRepository : EfCoreRepository<BlogDbContext, Author, Guid>, IAuthorRepository
    {
        public AuthorRepository(IDbContextProvider<BlogDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
