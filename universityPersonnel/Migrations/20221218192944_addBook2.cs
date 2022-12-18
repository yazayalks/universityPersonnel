using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace universityPersonnel.Migrations
{
    /// <inheritdoc />
    public partial class addBook2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_EmploymentBook_EmploymentBooksId",
                table: "Staff");

            migrationBuilder.RenameColumn(
                name: "EmploymentBooksId",
                table: "Staff",
                newName: "EmploymentBookId");

            migrationBuilder.RenameIndex(
                name: "IX_Staff_EmploymentBooksId",
                table: "Staff",
                newName: "IX_Staff_EmploymentBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_EmploymentBook_EmploymentBookId",
                table: "Staff",
                column: "EmploymentBookId",
                principalTable: "EmploymentBook",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_EmploymentBook_EmploymentBookId",
                table: "Staff");

            migrationBuilder.RenameColumn(
                name: "EmploymentBookId",
                table: "Staff",
                newName: "EmploymentBooksId");

            migrationBuilder.RenameIndex(
                name: "IX_Staff_EmploymentBookId",
                table: "Staff",
                newName: "IX_Staff_EmploymentBooksId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_EmploymentBook_EmploymentBooksId",
                table: "Staff",
                column: "EmploymentBooksId",
                principalTable: "EmploymentBook",
                principalColumn: "Id");
        }
    }
}
