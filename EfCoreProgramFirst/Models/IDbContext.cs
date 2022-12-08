using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EfCoreProgramFirst.Models
{
    internal class IDbContext : DbContext
    {
        public IDbContext()
        {

        }
        public DbSet<Person> Persons{get; set;}
        public DbSet<ProductionUnit> ProductionUnits { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<WebSeries> WebSeries { get; set; }

        public DbSet<Staff> staffs { get; set; }

        public DbSet<Doctor> doctors { get; set; }  

        public DbSet<Nurse> nurses { get; set; }
        public DbSet<Wardboy> wardboys { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog= CodiCodeFirst; Integrated Security = SSPI; Multiple Active Result Sets = true");
            base.OnConfiguring(optionsBuilder);    
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {

            var movies = new Movies[]
            {
                 new Movies(){ Id=1, Name="Dr.No",ReleaseYear=1963,
                     Category="Spy",BoxOfficeCollection=12222,PlayDuration=150},
                 new Movies(){ Id=2, Name="Golmal",ReleaseYear=1976,
                     Category="Comedy",BoxOfficeCollection=122,PlayDuration=180}
            };
            var series = new WebSeries[]
            {
                new WebSeries(){ Id=3, Name="Ramayan",ReleaseYear=1986,Seasons=2,EpisodPerSeason=100},
                new WebSeries(){ Id=4, Name="House of Cards",ReleaseYear=2005,Seasons=6,EpisodPerSeason=50}
            };

            var doctor = new Doctor[] { new Doctor() {Id =1 ,Name = "Divyansh", specialization = "Cancer", PateintCount= 10 },
            new Doctor() {Id =2 ,Name = "JayPrateek", specialization = "Heart", PateintCount= 20 }};
            var nurse = new Nurse[] { new Nurse() { Id = 3, Name = "Pranjali", specialization = "Cancer", RoomCount = 10 },
            new Nurse(){ Id = 4, Name = "divyanshi", specialization = "Heart", RoomCount = 20 } };
            var wardboy = new Wardboy[] { new Wardboy() { Id = 5, Name = "Subhankar", specialization = "Cancer", MachineCount = 10 },
            new Wardboy(){ Id = 6, Name = "Ankita", specialization = "Heart", MachineCount = 20 } }; 
            var productionUnit = movies.Cast<ProductionUnit>()
                    .Union(series)
                    .ToList();

            var staffdata = doctor.Cast<Staff>().Union(nurse).Union(wardboy).ToList();
            modelBuilder.Entity<Movies>().HasData(movies);
            modelBuilder.Entity<WebSeries>().HasData(series);

            modelBuilder.Entity<Doctor>().HasData(doctor);
            modelBuilder.Entity<Nurse>().HasData(nurse);
            modelBuilder.Entity<Wardboy>().HasData(wardboy);



            base.OnModelCreating(modelBuilder);
        }
    }
}
