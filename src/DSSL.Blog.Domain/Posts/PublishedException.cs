using Volo.Abp;

namespace DSSL.Blog.Posts
{
    public class PublishedException : BusinessException
    {
        public PublishedException(string code) : base(code) { }
    }
}
