using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;

namespace WpfApp2
{
    public class Person
    {

        //[Key]
        public int PersonId { get; set; }

        public string Name { get; set; }
        public int PostId { get; set; }
        public int SpecializationId { get; set; }
        public int DepartmentId { get; set; }

        public Person() { }

        public Person(string name)
        {
            Name = name;
        }
    }
}
