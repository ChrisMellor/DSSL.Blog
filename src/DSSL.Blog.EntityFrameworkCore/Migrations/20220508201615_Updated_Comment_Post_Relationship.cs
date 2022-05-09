using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Dssl.Blog.Migrations
{
    public partial class Updated_Comment_Post_Relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "BlogPost",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "BlogPost",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BlogPost",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "BlogPost",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "BlogPost");
        }
    }
}
