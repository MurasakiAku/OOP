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
    /// Логика взаимодействия для PersonForm.xaml
    /// </summary>
    public partial class PersonForm : Window
    {
        public Person Person { get; private set; }

        public PersonForm()
        {
            InitializeComponent();
            Person = new Person();
            DataContext = Person;
        }

        public PersonForm(Person person)
        {
            InitializeComponent();
            Person = person;
            DataContext = Person;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Person.LastName) ||
                string.IsNullOrWhiteSpace(Person.FirstName) ||
                string.IsNullOrWhiteSpace(Person.Position)) 
               
            {
                MessageBox.Show("Заполните обязательные поля!");
                return;
            }

            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
       
    }
}
