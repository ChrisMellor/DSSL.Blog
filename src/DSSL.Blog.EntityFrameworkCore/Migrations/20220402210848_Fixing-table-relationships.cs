using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSSL.Blog.Migrations
{
    public partial class Fixingtablerelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_BlogComment_Id",
                table: "BlogPost");

            migrationBuilder.DropIndex(
                name: "IX_BlogAuthor_Name",
                table: "BlogAuthor");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BlogAuthor");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComment_PostId",
                table: "BlogComment",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComment_BlogPost_PostId",
                table: "BlogComment",
                column: "PostId",
                principalTable: "BlogPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComment_BlogPost_PostId",
                table: "BlogComment");

            migrationBuilder.DropIndex(
                name: "IX_BlogComment_PostId",
                table: "BlogComment");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BlogAuthor",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_BlogAuthor_Name",
                table: "BlogAuthor",
                column: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPost_BlogComment_Id",
                table: "BlogPost",
                column: "Id",
                principalTable: "BlogComment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
