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

        public ICollection<City> Cities { get; set; } = new List<City>();
        public ICollection<Person> Persons { get; set; } = new List<Person>();
        public ICollection<BusinessTrip> BusinessTrips { get; set; } = new List<BusinessTrip>();
    }
}
