using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace universityPersonnel.Migrations
{
    /// <inheritdoc />
    public partial class addMovements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Movement_MovementId",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_MovementId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "MovementId",
                table: "Staff");

            migrationBuilder.CreateTable(
                name: "MovementStaff",
                columns: table => new
                {
                    MovementsId = table.Column<int>(type: "integer", nullable: false),
                    MovementsId1 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementStaff", x => new { x.MovementsId, x.MovementsId1 });
                    table.ForeignKey(
                        name: "FK_MovementStaff_Movement_MovementsId",
                        column: x => x.MovementsId,
                        principalTable: "Movement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovementStaff_Staff_MovementsId1",
                        column: x => x.MovementsId1,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovementStaff_MovementsId1",
                table: "MovementStaff",
                column: "MovementsId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovementStaff");

            migrationBuilder.AddColumn<int>(
                name: "MovementId",
                table: "Staff",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_MovementId",
                table: "Staff",
                column: "MovementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Movement_MovementId",
                table: "Staff",
                column: "MovementId",
                principalTable: "Movement",
                principalColumn: "Id");
        }
    }
}
