using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
        public DbSet<AccessRight> AccessRight { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserType> UserType { get; set; }
        public DbSet<NameForm> NameForm { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("db");
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=universityPersonne;Username=postgres;Password=6969");
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveConversion<UtcValueConverter>();
            configurationBuilder.Properties<DateTime?>().HaveConversion<UtcValueConverter>();
            base.ConfigureConventions(configurationBuilder);
        }

        private class UtcValueConverter : ValueConverter<DateTime, DateTime>
        {
            public UtcValueConverter()
                : base(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc))
            {
            }
        }

    }
}
