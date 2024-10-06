using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WpfApp2.DataAccess
{
    public class AppContex : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public AppContex() : base("DefaultConnection") 
        {
        
        }
    }
} 
