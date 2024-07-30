using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LocalGym.Migrations
{
    /// <inheritdoc />
    public partial class seedstesting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "Email", "FirstName", "JoinDate", "LastName" },
                values: new object[,]
                {
                    { 1, "aaa@gmail.com", "karpagam", new DateTime(2024, 7, 30, 21, 33, 38, 372, DateTimeKind.Local).AddTicks(345), "s" },
                    { 2, "aaa@gmail.com", "Hanumika", new DateTime(2024, 7, 30, 21, 33, 38, 372, DateTimeKind.Local).AddTicks(385), "g" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2);
        }
    }
}
