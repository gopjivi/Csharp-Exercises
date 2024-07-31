using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalGym.Migrations
{
    /// <inheritdoc />
    public partial class seedingvalues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2024, 7, 31, 10, 30, 50, 351, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2024, 7, 31, 10, 30, 50, 351, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "TrainerId", "FeePer30Minutes", "FirstName", "HireDate", "LastName", "Speciality" },
                values: new object[] { 1, 100.0, "Hanumika", new DateTime(2024, 7, 31, 10, 30, 50, 351, DateTimeKind.Local).AddTicks(9667), "g", "boxer" });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "SessionId", "CustomerId", "Duration", "SessionDate", "TrainerId" },
                values: new object[] { 1, 1, "90 mins", new DateTime(2024, 7, 31, 10, 30, 50, 351, DateTimeKind.Local).AddTicks(9714), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "SessionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2024, 7, 30, 21, 33, 38, 372, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberId",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2024, 7, 30, 21, 33, 38, 372, DateTimeKind.Local).AddTicks(385));
        }
    }
}
