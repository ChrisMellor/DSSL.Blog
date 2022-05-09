using Volo.Abp.Threading;

namespace Dssl.Blog.EntityFrameworkCore
{
    public static class BlogEfCoreEntityExtensionMappings
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            BlogGlobalFeatureConfigurator.Configure();
            BlogModuleExtensionConfigurator.Configure();

            OneTimeRunner.Run(() =>
            {

            });
        }
    }
}