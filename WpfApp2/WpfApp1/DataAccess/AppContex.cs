using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.DataAccess
{
    public class AppContex : DbContext
    {
        public AppContex(DbContextOptions<AppContex> options) : base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
        
    }
} 
