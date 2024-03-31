using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp2
{
    class BD
    {
        public class Person
        {
            public int IdPerson { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int IdPost { get; set; }
            public int IdSpecialization { get; set; }
            public int IdDepartment { get; set; }

            public Person(string FirstName, string LastName)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
            }
            public Person()
            {
                FirstName = "Ivan";
                LastName = "Ivanov";
            }
        }


        public class PersonInfo
        {
            public int IdPerson { get; set; }
            public DateTime DateBD { get; set; }
            public string Passport { get; set; }
            public string Gender { get; set; }
            public string MaritalStatus { get; set; }

            public PersonInfo(DateTime DateBD, string Passport, string Gender, string MaritalStatus)
            {
                this.DateBD = DateBD;
                this.Passport = Passport;
                this.Gender = Gender;
                this.MaritalStatus = MaritalStatus;
            }
            public PersonInfo()
            {
                DateBD = new DateTime(1999, 01, 01);
                Passport = "45 45 54212";
                Gender = "Men";
                MaritalStatus = "Not married";
            }
        }
        public class Adress
        {
            public int IdAdress { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public float House { get; set; }

            public Adress(string City, string Street, float House)
            {
                this.City = City;
                this.Street = Street;
                this.House = House;
            }
            public Adress()
            {
                City = "Novosibirsk";
                Street = "Lenina";
                House = 4 / 2;
            }
        }
        public class Specialization
        {
            public int IdSpecialization { get; set; }
            public string Specialty { get; set; }

            public Specialization(string Specialty)
            {
                this.Specialty = Specialty;
            }
            public Specialization()
            {
                Specialty = "Information systems technician";
            }
        }
        public class Position
        {
            public int IdPost { get; set; }
            public string NamePosition { get; set; }

            public Position(string NamePosition)
            {
                this.NamePosition = NamePosition;
            }
            public Position()
            {
                NamePosition = "IT Specialist";
            }
        }
        public class Department
        {
            public int IdDepartment { get; set; }
            public string NameDepartment { get; set; }
            public int IdPost { get; set; }

            public Department(string NameDepartment)
            {
                this.NameDepartment = NameDepartment;
            }
            public Department()
            {
                NameDepartment = "IT Department";
            }
        }
        public class BusinessTrips
        {
            public int IdPerson { get; set; }
            public int IdAdress { get; set; }
            public string Trips { get; set; }
            public DateTime dateTime { get; set; }
            public double Prepayment { get; set; }

            public BusinessTrips(string Trips, DateTime dateTime, double Prepayment)
            {
                this.Trips = Trips;
                this.dateTime = dateTime;
                this.Prepayment = Prepayment;
            }
            public BusinessTrips()
            {
                Trips = "IT conference";
                dateTime = new DateTime(2023, 01, 12);
                Prepayment = 78.456;
            }
        }
        //static void Main(string[] args)
        //{
        //}
    }
}
