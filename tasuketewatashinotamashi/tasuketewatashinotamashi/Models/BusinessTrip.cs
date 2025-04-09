using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasuketewatashinotamashi.Models
{
    public class BusinessTrip
    {
        [Key]
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public string City { get; set; }
        public string Purpose { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Budget { get; set; }
    }
}
