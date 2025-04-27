using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasuketewatashinotamashi.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
      
        public int? CityId { get; set; }
        public City City { get; set; }
        public int? SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
        public int? SubunitId { get; set; }
        public Subunit Subunit { get; set; }
        public int? PositionId { get; set; }
        public Position Position { get; set; }
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public int? StreetId { get; set; }
        public Street Street { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AndName { get; set; }
        public string Sex { get; set; }
        public decimal Salary { get; set; }


        public ICollection<BusinessTrip> BusinessTrips { get; set; } = new List<BusinessTrip>();
        public ICollection<Workbook> Workbooks { get; set; } = new List<Workbook>();





    }
}
