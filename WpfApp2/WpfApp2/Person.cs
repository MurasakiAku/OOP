using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;

namespace WpfApp2
{
    class Person
    {

        //[Key]
        public int idPerson { get; set; }

        public string name { get; set; }
        public int idPost { get; set; }
        public int idSpecialization { get; set; }
        public int idDepartment { get; set; }

        public Person() { }

        public Person(string name)
        {
            this.name = name;
        }
    }
}
