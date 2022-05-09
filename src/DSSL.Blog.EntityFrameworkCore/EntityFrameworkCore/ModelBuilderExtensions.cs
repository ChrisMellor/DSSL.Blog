using Dssl.Blog.Posts;
using Dssl.Blog.PostTags;
using Dssl.Blog.Tags;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Dssl.Blog.EntityFrameworkCore
{
    public static class ModelBuilderExtensions
    {
        public static void ConfigurePosts(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Post>(b =>
            {
                b.ToTable(BlogConsts.DbTablePrefix + nameof(Post), BlogConsts.DbSchema);
                b.ConfigureByConvention();

                b.HasIndex(x => x.Id);

                b.Property(x => x.Title)
                    .IsRequired();

                b.HasMany(x => x.Tags)
                    .WithOne()
                    .HasForeignKey(pt => pt.PostId);

                b.ApplyObjectExtensionMappings();
            });
        }

        public static void ConfigureTags(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Tag>(b =>
            {
                b.ToTable(BlogConsts.DbTablePrefix + nameof(Tag), BlogConsts.DbSchema);
                b.ConfigureByConvention();

                b.Property(x => x.Name)
                    .IsRequired();

                b.HasMany<PostTag>()
                    .WithOne()
                    .HasForeignKey(pt => pt.TagId);

                b.ApplyObjectExtensionMappings();
            });
        }

        public static void ConfigurePostTags(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<PostTag>(b =>
            {
                b.ToTable(BlogConsts.DbTablePrefix + nameof(PostTag), BlogConsts.DbSchema);
                b.ConfigureByConvention();

                b.Property(x => x.PostId).HasColumnName(nameof(PostTag.PostId));
                b.Property(x => x.TagId).HasColumnName(nameof(PostTag.TagId));

                b.HasKey(x => new { x.PostId, x.TagId });

                b.ApplyObjectExtensionMappings();
            });
        }
    }
}