using Volo.Abp.Threading;

namespace DSSL.Blog
{
    public static class BlogDtoExtensions
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            OneTimeRunner.Run(() => { });
        }
    }
}