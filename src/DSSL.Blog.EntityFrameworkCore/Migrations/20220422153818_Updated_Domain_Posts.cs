using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Dssl.Blog.Migrations
{
    public partial class Updated_Domain_Posts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_BlogAuthor_AuthorId",
                table: "BlogPost");

            migrationBuilder.DropTable(
                name: "BlogAuthor");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "BlogComment");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "BlogComment");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "BlogComment");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "BlogComment");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "BlogComment");

            migrationBuilder.RenameColumn(
                name: "LastModifierId",
                table: "BlogComment",
                newName: "PostId1");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "BlogPost",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "BlogPost",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LikesCount",
                table: "BlogPost",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPost_AbpUsers_AuthorId",
                table: "BlogPost",
                column: "AuthorId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComment_BlogPost_PostId1",
                table: "BlogComment");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_AbpUsers_AuthorId",
                table: "BlogPost");

            migrationBuilder.DropIndex(
                name: "IX_BlogComment_PostId1",
                table: "BlogComment");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "LikesCount",
                table: "BlogPost");

            migrationBuilder.RenameColumn(
                name: "PostId1",
                table: "BlogComment",
                newName: "LastModifierId");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "BlogComment",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "BlogComment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "BlogComment",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "BlogComment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "BlogComment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BlogAuthor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogAuthor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogAuthor_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogAuthor_UserId",
                table: "BlogAuthor",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPost_BlogAuthor_AuthorId",
                table: "BlogPost",
                column: "AuthorId",
                principalTable: "BlogAuthor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
