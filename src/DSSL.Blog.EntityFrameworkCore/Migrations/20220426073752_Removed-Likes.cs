using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSSL.Blog.Migrations
{
    public partial class RemovedLikes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LikesCount",
                table: "BlogPost");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LikesCount",
                table: "BlogPost",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
