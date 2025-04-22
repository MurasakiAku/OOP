using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace tasuketewatashinotamashi.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public string Name { get; set; }

        public List<Person> Persons { get; set; } = new();
        public List<Street> Streets { get; set; } = new();
        public List<BusinessTrip> BusinessTrips { get; set; } = new();
        public List<Organisation> Organisations { get; set; } = new();

    }
}
