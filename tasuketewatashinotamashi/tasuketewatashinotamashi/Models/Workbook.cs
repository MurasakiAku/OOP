using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasuketewatashinotamashi.Models
{
    public class Workbook
    {
        [Key]
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public string NameWordbook { get; set; }
        public int OrganisationId { get; set; }
        public Organisation Organisation { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
