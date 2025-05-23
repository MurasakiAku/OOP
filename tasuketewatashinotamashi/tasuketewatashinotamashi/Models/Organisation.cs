﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasuketewatashinotamashi.Models
{
    public class Organisation
    {
        [Key]
        public int Id { get; set; }
        public string NameOrganisation { get; set; }
        public string TaxNumber { get; set; }
        public int? CityId { get; set; }
        public City City { get; set; }

        public ICollection<Workbook> Workbooks { get; set; } = new List<Workbook>();


    }
}
