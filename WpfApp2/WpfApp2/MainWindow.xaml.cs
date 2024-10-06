using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using static WpfApp2.BD;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppContex db;
        public MainWindow()
        {
            InitializeComponent();

            db = new AppContex();
            //List<Person> persons = db.Persons.ToList();
            //string str = "";
            //foreach (Person person in persons)
            //    str += "ФИО " + person.name + " | ";

           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddBusinessTrips_Click(object sender, RoutedEventArgs e)
        {
            BusinessTripsForm businessTripsForm = new BusinessTripsForm();
            businessTripsForm.Show();
        }

        private void BackPage_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult message = MessageBox.Show("Хотите выйти?", "Выход", MessageBoxButton.YesNo);
            if (message == MessageBoxResult.Yes)
            {
                this.Close();
            }
            else if (message == MessageBoxResult.No)
            {
            }
            
        }

        private void SavePerson_Click(object sender, RoutedEventArgs e)
        {
            string name = textBoxNamePerson.Text.Trim();
            //string FirstName = textBoxNamePerson.Text.Trim();
            //DateTime DateBD = textBoxDB.Text.Trim();
            //string Passport = textBoxPassport.Text.Trim();
            //string Gender = textBoxGender.Text.Trim();
            //string City = textBoxCity.Text.Trim();
            //string Street = textBoxStreet.Text.Trim();
            //string House = textBoxHouse.Text.Trim();
            //string Number = textBoxNumberAppartment.Text.Trim();

            Person person = new Person(name);
            db.Persons.Add(person);
            db.SaveChanges();
        }

        private void TextBoxNamePerson_TextChanged(object sender, TextChangedEventArgs e)
        {
            //BD bD = new BD();
            //db.bDs.Add();
        }

        private void TextBoxDB_TextChanged(object sender, TextChangedEventArgs e)
        {
            //BD bD = new BD(DateBD);
            //db.bDs.Add();

        }
    }
}
