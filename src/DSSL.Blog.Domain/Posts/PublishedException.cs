using Volo.Abp;

namespace Dssl.Blog.Posts
{
    public class PublishedException : BusinessException
    {
        public PublishedException(string code) : base(code) { }
    }
}