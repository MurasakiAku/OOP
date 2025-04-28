using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
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
    /// Логика взаимодействия для PersonEditDialog.xaml
    /// </summary>
    public partial class PersonEditDialog : Window
    {
        public Person Person { get; private set; }
        public BusinessTrip BusinessTrip { get; private set; }
        Person _person;
        Workbook workbook;
        BusinessTrip _businesstrip;
        MyDbContext _db;
        public PersonEditDialog(MyDbContext db, Person person, BusinessTrip businesstrip, Workbook workbook)
        {
            InitializeComponent();
            _person = person;
            _db = db;
            Person = new Person
            {
                WorkBook = new WorkBook(),
                BusinessTrip = new BusinessTrip()
            };
            DataContext = this;
            LoadReferenceData();

        }
        public PersonEditDialog(Person person) : this()
        {
            Person = person;
            _db.Attach(Person);

            if (Person.WorkBook == null) Person.WorkBook = new WorkBook();
            if (Person.BusinessTrip == null) Person.BusinessTrip = new BusinessTrip();

            BusinessTripCheckBox.IsChecked = Person.BusinessTripId.HasValue;
        }

        private void LoadReferenceData()
        {
            _db.Countries.Load();
            CountryComboBox.ItemsSource = _db.Countries.Local.ToObservableCollection();

            _db.Organisations.Load();
            OrganisationComboBox.ItemsSource = _db.Organisations.Local.ToObservableCollection();
            BusinessTripOrganisationComboBox.ItemsSource = _db.Organisations.Local.ToObservableCollection();

            _db.Specialities.Load();
            SpecialityComboBox.ItemsSource = _db.Specialities.Local.ToObservableCollection();

            CountryComboBox.SelectionChanged += (s, e) => LoadCities();
            CityComboBox.SelectionChanged += (s, e) => LoadStreets();
        }

        private void LoadCities()
        {
            if (CountryComboBox.SelectedValue is int countryId)
            {
                _db.Citys.Where(c => c.CountryId == countryId).Load();
                CityComboBox.ItemsSource = _db.Citys.Local.ToObservableCollection();
            }
        }

        private void LoadStreets()
        {
            if (CityComboBox.SelectedValue is int cityId)
            {
                _db.Streets.Where(s => s.CityId == cityId).Load();
            }
            StreetComboBox.ItemsSource = _db.Streets.Local.ToObservableCollection();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
        private void OK_Click(object sender, RoutedEventArgs e)
    {
        if (BusinessTripCheckBox.IsChecked != true)
        {
                BusinessTrip.Person = null;
                BusinessTrip.PersonId = null;
       
        }

        
        DialogResult = true;
        Close();
    }
    }


    

    
}
