using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace tasuketewatashinotamashi.Models
{
    public class Street
    {
        [Key]
        public int Id { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public string NameStreet { get; set; }

        public List<Person> Persons { get; set; } = new();
    }
}
