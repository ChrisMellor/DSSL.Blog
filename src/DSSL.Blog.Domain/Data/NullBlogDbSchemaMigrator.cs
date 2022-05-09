using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DSSL.Blog.Data
{
    public class NullBlogDbSchemaMigrator : IBlogDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
