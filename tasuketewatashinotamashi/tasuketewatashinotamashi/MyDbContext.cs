using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tasuketewatashinotamashi.Models;

namespace tasuketewatashinotamashi
{
    class MyDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=MyDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
