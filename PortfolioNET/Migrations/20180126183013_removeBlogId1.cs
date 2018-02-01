using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioNET.Migrations
{
    public partial class removeBlogId1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blog_BlogId1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_BlogId1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "BlogId1",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "BlogId",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogId",
                table: "Comments",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blog_BlogId",
                table: "Comments",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blog_BlogId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_BlogId",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "BlogId1",
                table: "Comments",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BlogId",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogId1",
                table: "Comments",
                column: "BlogId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blog_BlogId1",
                table: "Comments",
                column: "BlogId1",
                principalTable: "Blog",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
