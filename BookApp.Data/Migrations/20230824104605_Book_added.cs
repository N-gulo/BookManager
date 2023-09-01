using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Book_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Books",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "ISBN", "Language", "PublicationYear", "ShortDescription", "Title" },
                values: new object[] { 1, 1, "123-456-789", "English", new DateTime(2010, 1, 1, 0, 0, 15, 0, DateTimeKind.Utc), "A very sad book like the name implies", "Grave of fireflies" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Books",
                newName: "id");
        }
    }
}
