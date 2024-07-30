using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalGym.Migrations
{
    /// <inheritdoc />
    public partial class updatedmembertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Sessions_SessionId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_SessionId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "Members");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SessionId",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Members_SessionId",
                table: "Members",
                column: "SessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Sessions_SessionId",
                table: "Members",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "SessionId");
        }
    }
}
