using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public class Person
        {
            public int IdPerson { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int IdPost { get; set; }
            public int IdSpecialization { get; set; }
            public int IdDepartment { get; set; }
        }
        public class PersonInfo
        { 
            public int IdPerson { get; set; }
            public DateTime DateBD { get; set; }
            public char Passport { get; set; }
            public string MaritalStatus { get; set; }
        }
        public class Adress
        {
            public int IdAdress { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
        }
        public class Specialization
        {
            public int IdSpecialization { get; set; }
            public string Specialty { get; set; }
        }
        public class Position 
        {
            public int IdPost { get; set; }
            public string NamePosition { get; set; }
        }
        public class Department
        { 
            public int IdDepartment { get; set; }
            public string NameDepartment { get; set; }
            public int IdPost { get; set; }

        }
        public class BusinessTrips
        {
            public int IdPerson { get; set; }
            public int IdAdress { get; set; }
            public string Trips { get; set; }
            public DateTime dateTime { get; set; }
            public double Prepayment { get; set; }
        }
        static void Main(string[] args)
        {
        }
    }
}
