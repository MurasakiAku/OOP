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

        public List<Person> Persons { get; set; } = new();
        public List<Workbook> Workbooks { get; set; } = new();
    }
}
