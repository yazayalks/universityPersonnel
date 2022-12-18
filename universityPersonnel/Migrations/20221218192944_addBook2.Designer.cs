﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using universityPersonnel;

#nullable disable

namespace universityPersonnel.Migrations
{
    [DbContext(typeof(UniversityPersonnelDbContext))]
    [Migration("20221218192944_addBook2")]
    partial class addBook2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("universityPersonnel.Models.AcademicDegree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AcademicDegree");
                });

            modelBuilder.Entity("universityPersonnel.Models.AcademicTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AcademicTitle");
                });

            modelBuilder.Entity("universityPersonnel.Models.EmploymentBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ReasonDismissal")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Satrt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("EmploymentBook");
                });

            modelBuilder.Entity("universityPersonnel.Models.Encouragement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("EncouragementTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EncouragementTypeId");

                    b.ToTable("Encouragement");
                });

            modelBuilder.Entity("universityPersonnel.Models.EncouragementType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EncouragementType");
                });

            modelBuilder.Entity("universityPersonnel.Models.JobTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("JobTitle");
                });

            modelBuilder.Entity("universityPersonnel.Models.Movement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cause")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Movement");
                });

            modelBuilder.Entity("universityPersonnel.Models.Penaltie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<int?>("PenaltieTypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PenaltieTypeId");

                    b.ToTable("Penaltie");
                });

            modelBuilder.Entity("universityPersonnel.Models.PenaltieType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PenaltieType");
                });

            modelBuilder.Entity("universityPersonnel.Models.PreviousVenture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PreviousVenture");
                });

            modelBuilder.Entity("universityPersonnel.Models.Speciality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Speciality");
                });

            modelBuilder.Entity("universityPersonnel.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AcademicDegreeId")
                        .HasColumnType("integer");

                    b.Property<int?>("AcademicTitleId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateIssuePassport")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("EmploymentBookId")
                        .HasColumnType("integer");

                    b.Property<int?>("EncouragementId")
                        .HasColumnType("integer");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HomeAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("JobTitleId")
                        .HasColumnType("integer");

                    b.Property<string>("Middlename")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("MovementId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PassportId")
                        .HasColumnType("integer");

                    b.Property<string>("PassportIssuedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PenaltieId")
                        .HasColumnType("integer");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PlaceBirth")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PreviousVentureId")
                        .HasColumnType("integer");

                    b.Property<int?>("SpecialityId")
                        .HasColumnType("integer");

                    b.Property<int?>("SubdivisionId")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("YearGraduation")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AcademicDegreeId");

                    b.HasIndex("AcademicTitleId");

                    b.HasIndex("EmploymentBookId");

                    b.HasIndex("EncouragementId");

                    b.HasIndex("JobTitleId");

                    b.HasIndex("MovementId");

                    b.HasIndex("PenaltieId");

                    b.HasIndex("PreviousVentureId");

                    b.HasIndex("SpecialityId");

                    b.HasIndex("SubdivisionId");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("universityPersonnel.Models.Subdivision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Subdivision");
                });

            modelBuilder.Entity("universityPersonnel.Models.Encouragement", b =>
                {
                    b.HasOne("universityPersonnel.Models.EncouragementType", null)
                        .WithMany("EncouragementTypes")
                        .HasForeignKey("EncouragementTypeId");
                });

            modelBuilder.Entity("universityPersonnel.Models.Penaltie", b =>
                {
                    b.HasOne("universityPersonnel.Models.PenaltieType", null)
                        .WithMany("PenaltieTypes")
                        .HasForeignKey("PenaltieTypeId");
                });

            modelBuilder.Entity("universityPersonnel.Models.Staff", b =>
                {
                    b.HasOne("universityPersonnel.Models.AcademicDegree", "AcademicDegree")
                        .WithMany("AcademicDegrees")
                        .HasForeignKey("AcademicDegreeId");

                    b.HasOne("universityPersonnel.Models.AcademicTitle", "AcademicTitle")
                        .WithMany("AcademicTitles")
                        .HasForeignKey("AcademicTitleId");

                    b.HasOne("universityPersonnel.Models.EmploymentBook", "EmploymentBook")
                        .WithMany("EmploymentBooks")
                        .HasForeignKey("EmploymentBookId");

                    b.HasOne("universityPersonnel.Models.Encouragement", "Encouragement")
                        .WithMany("Encouragements")
                        .HasForeignKey("EncouragementId");

                    b.HasOne("universityPersonnel.Models.JobTitle", "JobTitle")
                        .WithMany("JobTitles")
                        .HasForeignKey("JobTitleId");

                    b.HasOne("universityPersonnel.Models.Movement", "Movement")
                        .WithMany("Movements")
                        .HasForeignKey("MovementId");

                    b.HasOne("universityPersonnel.Models.Penaltie", "Penaltie")
                        .WithMany("Penalties")
                        .HasForeignKey("PenaltieId");

                    b.HasOne("universityPersonnel.Models.PreviousVenture", "PreviousVenture")
                        .WithMany("PreviousVentures")
                        .HasForeignKey("PreviousVentureId");

                    b.HasOne("universityPersonnel.Models.Speciality", "Speciality")
                        .WithMany("Specialties")
                        .HasForeignKey("SpecialityId");

                    b.HasOne("universityPersonnel.Models.Subdivision", "Subdivision")
                        .WithMany("Subdivisions")
                        .HasForeignKey("SubdivisionId");

                    b.Navigation("AcademicDegree");

                    b.Navigation("AcademicTitle");

                    b.Navigation("EmploymentBook");

                    b.Navigation("Encouragement");

                    b.Navigation("JobTitle");

                    b.Navigation("Movement");

                    b.Navigation("Penaltie");

                    b.Navigation("PreviousVenture");

                    b.Navigation("Speciality");

                    b.Navigation("Subdivision");
                });

            modelBuilder.Entity("universityPersonnel.Models.AcademicDegree", b =>
                {
                    b.Navigation("AcademicDegrees");
                });

            modelBuilder.Entity("universityPersonnel.Models.AcademicTitle", b =>
                {
                    b.Navigation("AcademicTitles");
                });

            modelBuilder.Entity("universityPersonnel.Models.EmploymentBook", b =>
                {
                    b.Navigation("EmploymentBooks");
                });

            modelBuilder.Entity("universityPersonnel.Models.Encouragement", b =>
                {
                    b.Navigation("Encouragements");
                });

            modelBuilder.Entity("universityPersonnel.Models.EncouragementType", b =>
                {
                    b.Navigation("EncouragementTypes");
                });

            modelBuilder.Entity("universityPersonnel.Models.JobTitle", b =>
                {
                    b.Navigation("JobTitles");
                });

            modelBuilder.Entity("universityPersonnel.Models.Movement", b =>
                {
                    b.Navigation("Movements");
                });

            modelBuilder.Entity("universityPersonnel.Models.Penaltie", b =>
                {
                    b.Navigation("Penalties");
                });

            modelBuilder.Entity("universityPersonnel.Models.PenaltieType", b =>
                {
                    b.Navigation("PenaltieTypes");
                });

            modelBuilder.Entity("universityPersonnel.Models.PreviousVenture", b =>
                {
                    b.Navigation("PreviousVentures");
                });

            modelBuilder.Entity("universityPersonnel.Models.Speciality", b =>
                {
                    b.Navigation("Specialties");
                });

            modelBuilder.Entity("universityPersonnel.Models.Subdivision", b =>
                {
                    b.Navigation("Subdivisions");
                });
#pragma warning restore 612, 618
        }
    }
}
