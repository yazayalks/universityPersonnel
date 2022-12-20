using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace universityPersonnel.Migrations
{
    /// <inheritdoc />
    public partial class AddPin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Penaltie_PenaltieId",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_PenaltieId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "PenaltieId",
                table: "Staff");

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Penaltie",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Penaltie_StaffId",
                table: "Penaltie",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Penaltie_Staff_StaffId",
                table: "Penaltie",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Penaltie_Staff_StaffId",
                table: "Penaltie");

            migrationBuilder.DropIndex(
                name: "IX_Penaltie_StaffId",
                table: "Penaltie");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Penaltie");

            migrationBuilder.AddColumn<int>(
                name: "PenaltieId",
                table: "Staff",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_PenaltieId",
                table: "Staff",
                column: "PenaltieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Penaltie_PenaltieId",
                table: "Staff",
                column: "PenaltieId",
                principalTable: "Penaltie",
                principalColumn: "Id");
        }
    }
}
