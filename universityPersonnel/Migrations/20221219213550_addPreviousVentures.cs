using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace universityPersonnel.Migrations
{
    /// <inheritdoc />
    public partial class addPreviousVentures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_PreviousVenture_PreviousVentureId",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_PreviousVentureId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "PreviousVentureId",
                table: "Staff");

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "PreviousVenture",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PreviousVenture_StaffId",
                table: "PreviousVenture",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_PreviousVenture_Staff_StaffId",
                table: "PreviousVenture",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PreviousVenture_Staff_StaffId",
                table: "PreviousVenture");

            migrationBuilder.DropIndex(
                name: "IX_PreviousVenture_StaffId",
                table: "PreviousVenture");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "PreviousVenture");

            migrationBuilder.AddColumn<int>(
                name: "PreviousVentureId",
                table: "Staff",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_PreviousVentureId",
                table: "Staff",
                column: "PreviousVentureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_PreviousVenture_PreviousVentureId",
                table: "Staff",
                column: "PreviousVentureId",
                principalTable: "PreviousVenture",
                principalColumn: "Id");
        }
    }
}
