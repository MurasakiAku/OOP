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
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public string Name { get; set; }

        public ICollection<Person> Persons { get; set; } = new List<Person>();
        public ICollection<Street> Streets { get; set; } = new List<Street>();
        public ICollection<BusinessTrip> BusinessTrips { get; set; } = new List<BusinessTrip>();
        public ICollection<Organisation> Organisations { get; set; } = new List<Organisation>();

    }
}
