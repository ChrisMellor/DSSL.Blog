using DSSL.Blog.Comments;
using DSSL.Blog.Posts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace DSSL.Blog.EntityFrameworkCore
{
    public static class ModelBuilderExtensions
    {
        public static void ConfigurePost(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Post>(b =>
            {
                b.ToTable(BlogConsts.DbTablePrefix + nameof(Post), BlogConsts.DbSchema);

                b.ConfigureByConvention();

                b.Property(x => x.Title)
                    .IsRequired();

                b.HasIndex(x => x.Id);

                b.HasOne<IdentityUser>()
                    .WithMany()
                    .HasForeignKey(x => x.AuthorId)
                    .IsRequired();

                b.Property(x => x.Tags)
                    .HasConversion(Converters.Collection());
            });
        }

        public static void ConfigureComment(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Comment>(b =>
            {
                b.ToTable(BlogConsts.DbTablePrefix + nameof(Comment), BlogConsts.DbSchema);

                b.ConfigureByConvention();

                b.Property(x => x.Message)
                    .IsRequired();

                b.HasIndex(x => x.Id);

                b.HasOne<Post>()
                    .WithMany()
                    .HasForeignKey(x => x.PostId);
            });
        }
    }
}
