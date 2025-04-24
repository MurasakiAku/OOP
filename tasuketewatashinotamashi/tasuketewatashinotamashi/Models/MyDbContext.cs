using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasuketewatashinotamashi.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<BusinessTrip> BusinessTrips { get; set; }
        public DbSet<City> Citys { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Subunit> Subunits { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<Workbook> Workbooks { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=MyDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
