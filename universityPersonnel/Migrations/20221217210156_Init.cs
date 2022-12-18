using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace universityPersonnel.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicDegree",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Degree = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicDegree", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AcademicTitle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicTitle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentBook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Satrt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    End = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    JobTitle = table.Column<string>(type: "text", nullable: false),
                    ReasonDismissal = table.Column<string>(type: "text", nullable: false),
                    EmploymentBookId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentBook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmploymentBook_EmploymentBook_EmploymentBookId",
                        column: x => x.EmploymentBookId,
                        principalTable: "EmploymentBook",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EncouragementType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncouragementType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTitle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cause = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PenaltieType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PenaltieType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreviousVenture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreviousVenture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speciality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subdivision",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subdivision", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Encouragement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    EncouragementTypeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encouragement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Encouragement_EncouragementType_EncouragementTypeId",
                        column: x => x.EncouragementTypeId,
                        principalTable: "EncouragementType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Penaltie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    PenaltieTypeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Penaltie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Penaltie_PenaltieType_PenaltieTypeId",
                        column: x => x.PenaltieTypeId,
                        principalTable: "PenaltieType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Middlename = table.Column<string>(type: "text", nullable: false),
                    Floor = table.Column<string>(type: "text", nullable: false),
                    PlaceBirth = table.Column<string>(type: "text", nullable: false),
                    HomeAddress = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: false),
                    Education = table.Column<string>(type: "text", nullable: false),
                    PassportIssuedBy = table.Column<string>(type: "text", nullable: false),
                    PassportId = table.Column<int>(type: "integer", nullable: false),
                    DateIssuePassport = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    YearGraduation = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AcademicDegreeId = table.Column<int>(type: "integer", nullable: true),
                    AcademicTitleId = table.Column<int>(type: "integer", nullable: true),
                    EncouragementId = table.Column<int>(type: "integer", nullable: true),
                    JobTitleId = table.Column<int>(type: "integer", nullable: true),
                    MovementId = table.Column<int>(type: "integer", nullable: true),
                    PenaltieId = table.Column<int>(type: "integer", nullable: true),
                    PreviousVentureId = table.Column<int>(type: "integer", nullable: true),
                    SpecialityId = table.Column<int>(type: "integer", nullable: true),
                    SubdivisionId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_AcademicDegree_AcademicDegreeId",
                        column: x => x.AcademicDegreeId,
                        principalTable: "AcademicDegree",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_AcademicTitle_AcademicTitleId",
                        column: x => x.AcademicTitleId,
                        principalTable: "AcademicTitle",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_Encouragement_EncouragementId",
                        column: x => x.EncouragementId,
                        principalTable: "Encouragement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_JobTitle_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitle",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_Movement_MovementId",
                        column: x => x.MovementId,
                        principalTable: "Movement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_Penaltie_PenaltieId",
                        column: x => x.PenaltieId,
                        principalTable: "Penaltie",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_PreviousVenture_PreviousVentureId",
                        column: x => x.PreviousVentureId,
                        principalTable: "PreviousVenture",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_Speciality_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Speciality",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_Subdivision_SubdivisionId",
                        column: x => x.SubdivisionId,
                        principalTable: "Subdivision",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentBook_EmploymentBookId",
                table: "EmploymentBook",
                column: "EmploymentBookId");

            migrationBuilder.CreateIndex(
                name: "IX_Encouragement_EncouragementTypeId",
                table: "Encouragement",
                column: "EncouragementTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Penaltie_PenaltieTypeId",
                table: "Penaltie",
                column: "PenaltieTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_AcademicDegreeId",
                table: "Staff",
                column: "AcademicDegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_AcademicTitleId",
                table: "Staff",
                column: "AcademicTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_EncouragementId",
                table: "Staff",
                column: "EncouragementId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_JobTitleId",
                table: "Staff",
                column: "JobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_MovementId",
                table: "Staff",
                column: "MovementId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_PenaltieId",
                table: "Staff",
                column: "PenaltieId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_PreviousVentureId",
                table: "Staff",
                column: "PreviousVentureId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_SpecialityId",
                table: "Staff",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_SubdivisionId",
                table: "Staff",
                column: "SubdivisionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmploymentBook");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "AcademicDegree");

            migrationBuilder.DropTable(
                name: "AcademicTitle");

            migrationBuilder.DropTable(
                name: "Encouragement");

            migrationBuilder.DropTable(
                name: "JobTitle");

            migrationBuilder.DropTable(
                name: "Movement");

            migrationBuilder.DropTable(
                name: "Penaltie");

            migrationBuilder.DropTable(
                name: "PreviousVenture");

            migrationBuilder.DropTable(
                name: "Speciality");

            migrationBuilder.DropTable(
                name: "Subdivision");

            migrationBuilder.DropTable(
                name: "EncouragementType");

            migrationBuilder.DropTable(
                name: "PenaltieType");
        }
    }
}
