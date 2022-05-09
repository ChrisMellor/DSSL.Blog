using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSSL.Blog.Migrations
{
    public partial class Removed_Comments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogComment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogComment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogComment_BlogPost_PostId",
                        column: x => x.PostId,
                        principalTable: "BlogPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogComment_Id",
                table: "BlogComment",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComment_PostId",
                table: "BlogComment",
                column: "PostId");
        }
    }
}
