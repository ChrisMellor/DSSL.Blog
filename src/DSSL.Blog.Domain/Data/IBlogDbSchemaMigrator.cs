using System.Threading.Tasks;

namespace DSSL.Blog.Data;

public interface IBlogDbSchemaMigrator
{
    Task MigrateAsync();
}
