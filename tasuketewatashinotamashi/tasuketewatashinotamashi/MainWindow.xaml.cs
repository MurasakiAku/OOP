using Microsoft.EntityFrameworkCore;
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
using tasuketewatashinotamashi.Models;

namespace tasuketewatashinotamashi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person _person;
        MyDbContext _db;
        public MainWindow(MyDbContext db,  Person person)
        {
            _person = person;
            _db= db;
            InitializeComponent();
            if (person != null ) 
            {
                textBoxFirstNamePerson.Text = person.FirstName;
                textBoxLastNamePerson.Text = person.LastName;
                textBoxAndNamePerson.Text = person.AndName;
                textBoxPosition.Text = person.Position;
                textBoxSalaty.Text = person.Salary.ToString();
            }
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
            Person _person = new Person();
            decimal salary = Convert.ToInt32(textBoxSalaty.Text);
            _person.FirstName = textBoxFirstNamePerson.Text;
            _person.LastName = textBoxLastNamePerson.Text;
            _person.AndName = textBoxAndNamePerson.Text;
            _person.Position = textBoxPosition.Text;
            _person.Salary = salary;
            _db.Persons.Add(_person);
            _db.SaveChanges();


        }

        private void TextBoxNamePerson_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }

        private void TextBoxDB_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
