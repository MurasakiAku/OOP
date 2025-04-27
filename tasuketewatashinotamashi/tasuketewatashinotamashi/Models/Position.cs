using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasuketewatashinotamashi.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        public string NamePosition { get; set; }

        public ICollection<Person> Persons { get; set; } = new List<Person>();
        public ICollection<Workbook> Workbooks { get; set; } = new List<Workbook>();
    }
}
