using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Dssl.Blog.Migrations
{
    public partial class PostAudited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_AbpUsers_AuthorId",
                table: "BlogPost");

            migrationBuilder.DropIndex(
                name: "IX_BlogPost_AuthorId",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "BlogPost");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "BlogPost",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "BlogPost",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "BlogPost",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "BlogPost",
                type: "uniqueidentifier",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "BlogPost");

            migrationBuilder.AddColumn<Guid>(
                name: "AuthorId",
                table: "BlogPost",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_AuthorId",
                table: "BlogPost",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPost_AbpUsers_AuthorId",
                table: "BlogPost",
                column: "AuthorId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
