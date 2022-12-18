using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using universityPersonnel.Models;

namespace universityPersonnel
{
    public class UniversityPersonnelDbContext : DbContext
    { 
        public DbSet<Staff> Staff { get; set; }
        public DbSet<AcademicDegree> AcademicDegree { get; set; }
        public DbSet<AcademicTitle> AcademicTitle { get; set; }
        public DbSet<EmploymentBook> EmploymentBook { get; set; }
        public DbSet<Encouragement> Encouragement { get; set; }
        public DbSet<EncouragementType> EncouragementType { get; set; }
        public DbSet<JobTitle> JobTitle { get; set; }
        public DbSet<Movement> Movement { get; set; }
        public DbSet<Penaltie> Penaltie { get; set; }
        public DbSet<PenaltieType> PenaltieType { get; set; }
        public DbSet<PreviousVenture> PreviousVenture { get; set; }
        public DbSet<Speciality> Speciality { get; set; }
        public DbSet<Subdivision> Subdivision { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=universityPersonne;Username=postgres;Password=6969");
        }

    }
}
