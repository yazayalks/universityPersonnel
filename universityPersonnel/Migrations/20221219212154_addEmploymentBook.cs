using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace universityPersonnel.Migrations
{
    /// <inheritdoc />
    public partial class addEmploymentBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_EmploymentBook_EmploymentBookId",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_EmploymentBookId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "EmploymentBookId",
                table: "Staff");

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "EmploymentBook",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentBook_StaffId",
                table: "EmploymentBook",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmploymentBook_Staff_StaffId",
                table: "EmploymentBook",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmploymentBook_Staff_StaffId",
                table: "EmploymentBook");

            migrationBuilder.DropIndex(
                name: "IX_EmploymentBook_StaffId",
                table: "EmploymentBook");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "EmploymentBook");

            migrationBuilder.AddColumn<int>(
                name: "EmploymentBookId",
                table: "Staff",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_EmploymentBookId",
                table: "Staff",
                column: "EmploymentBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_EmploymentBook_EmploymentBookId",
                table: "Staff",
                column: "EmploymentBookId",
                principalTable: "EmploymentBook",
                principalColumn: "Id");
        }
    }
}
