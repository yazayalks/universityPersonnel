using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace universityPersonnel.Migrations
{
    /// <inheritdoc />
    public partial class addBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmploymentBook_EmploymentBook_EmploymentBookId",
                table: "EmploymentBook");

            migrationBuilder.DropIndex(
                name: "IX_EmploymentBook_EmploymentBookId",
                table: "EmploymentBook");

            migrationBuilder.DropColumn(
                name: "EmploymentBookId",
                table: "EmploymentBook");

            migrationBuilder.AddColumn<int>(
                name: "EmploymentBooksId",
                table: "Staff",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_EmploymentBooksId",
                table: "Staff",
                column: "EmploymentBooksId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_EmploymentBook_EmploymentBooksId",
                table: "Staff",
                column: "EmploymentBooksId",
                principalTable: "EmploymentBook",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_EmploymentBook_EmploymentBooksId",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_EmploymentBooksId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "EmploymentBooksId",
                table: "Staff");

            migrationBuilder.AddColumn<int>(
                name: "EmploymentBookId",
                table: "EmploymentBook",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentBook_EmploymentBookId",
                table: "EmploymentBook",
                column: "EmploymentBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmploymentBook_EmploymentBook_EmploymentBookId",
                table: "EmploymentBook",
                column: "EmploymentBookId",
                principalTable: "EmploymentBook",
                principalColumn: "Id");
        }
    }
}
