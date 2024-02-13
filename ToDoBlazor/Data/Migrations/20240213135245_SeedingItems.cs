using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToDoBlazor.Migrations
{
    /// <inheritdoc />
    public partial class SeedingItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ToDoItems",
                columns: new[] { "Id", "CreateDate", "DisplayLabel", "Done" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vider la poubelle", false },
                    { 2, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ranger la chambre ", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
