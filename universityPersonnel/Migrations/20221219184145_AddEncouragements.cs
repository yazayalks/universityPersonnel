using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace universityPersonnel.Migrations
{
    /// <inheritdoc />
    public partial class AddEncouragements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Encouragement_EncouragementId",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_EncouragementId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "EncouragementId",
                table: "Staff");

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Encouragement",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Encouragement_StaffId",
                table: "Encouragement",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Encouragement_Staff_StaffId",
                table: "Encouragement",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Encouragement_Staff_StaffId",
                table: "Encouragement");

            migrationBuilder.DropIndex(
                name: "IX_Encouragement_StaffId",
                table: "Encouragement");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Encouragement");

            migrationBuilder.AddColumn<int>(
                name: "EncouragementId",
                table: "Staff",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_EncouragementId",
                table: "Staff",
                column: "EncouragementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Encouragement_EncouragementId",
                table: "Staff",
                column: "EncouragementId",
                principalTable: "Encouragement",
                principalColumn: "Id");
        }
    }
}
