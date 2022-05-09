using System.Threading.Tasks;

namespace Dssl.Blog.Data
{
    public interface IBlogDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}