using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Dssl.Blog.Data
{
    public class NullBlogDbSchemaMigrator : IBlogDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
