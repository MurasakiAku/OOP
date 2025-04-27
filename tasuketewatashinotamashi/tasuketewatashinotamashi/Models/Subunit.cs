using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasuketewatashinotamashi.Models
{
    public class Subunit
    {
        [Key]
        public int Id { get; set; }
        public string NameSubunit { get; set; }

        public ICollection<Person> Persons { get; set; } = new List<Person>();

    }
}
