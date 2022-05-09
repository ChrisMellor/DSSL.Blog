using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Dssl.Blog.Migrations
{
    public partial class Correcting_Post_Comment_Relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComment_BlogPost_PostId1",
                table: "BlogComment");

            migrationBuilder.DropIndex(
                name: "IX_BlogComment_PostId1",
                table: "BlogComment");

            migrationBuilder.DropColumn(
                name: "PostId1",
                table: "BlogComment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PostId1",
                table: "BlogComment",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogComment_PostId1",
                table: "BlogComment",
                column: "PostId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComment_BlogPost_PostId1",
                table: "BlogComment",
                column: "PostId1",
                principalTable: "BlogPost",
                principalColumn: "Id");
        }
    }
}
