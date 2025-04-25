using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace tasuketewatashinotamashi.Models
{
    public  class Country
    {
        [Key]
        public int Id { get; set; }
        public string NameCountry { get; set; }

        public List<City> Citys { get; set; } = new();
        public List<Person> Persons { get; set; } = new();
        public List<BusinessTrip> BusinessTrips { get; set; } = new();
    }
}
