using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace DSSL.Blog.Authors
{
    public class AuthorManager : DomainService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorManager(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<Author> CreateAsync(Guid userId)
        {
            var existingAuthor = await _authorRepository.FindAsync(x => x.UserId == userId);
            if (existingAuthor != null)
            {
                throw new Exception("User is already an Author");
            }

            return new Author(GuidGenerator.Create(), userId);
        }
    }
}
