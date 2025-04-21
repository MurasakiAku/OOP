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
        
        public Person Person { get; private set; }
        public BusinessTrip BusinessTrip { get; private set; }
        Person _person;
        BusinessTrip _businesstrip;
        MyDbContext _db;
        public MainWindow(MyDbContext db, Person person, BusinessTrip businesstrip)
        {
            _businesstrip = businesstrip;
            _person = person;
            _db= db;
            InitializeComponent();
            //LoadData();

        }
        ////private void LoadData()
        ////{
        ////    PersonGrid.ItemsSource = _db.Persons.ToList();
        ////    TripsGrid.ItemsSource = _db.BusinessTrips.Include(t => t.Person).ToList();
        ////}

        //private void AddPerson_Click(object sender, RoutedEventArgs e)
        //{
        //    //var form = new PersonForm();
        //    //if (form.ShowDialog() == true)
        //    //{
        //    //    _db.Persons.Add(form.Person);
        //    //    _db.SaveChanges();
        //    //    LoadData();
        //    //}
        //}

        //private void EditPerson_Click(object sender, RoutedEventArgs e)
        //{
        //    //var id = (int)((Button)sender).Tag;
        //    //var persons = _db.Persons.Find(id);
        //    //var form = new PersonForm(persons);
        //    //if (form.ShowDialog() == true)
        //    //{
        //    //    _db.SaveChanges();
        //    //    LoadData();
        //    //}
        //}

        //private void DeletePerson_Click(object sender, RoutedEventArgs e)
        //{
        //    var id = (int)((Button)sender).Tag;
        //    var persons = _db.Persons.Include(e => e.BusinessTrips).First(e => e.Id == id);

        //    if (persons.BusinessTrips.Any())
        //    {
        //        MessageBox.Show("Нельзя удалить сотрудника с командировками!");
        //        return;
        //    }

        //    if (MessageBox.Show("Удалить сотрудника?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
        //    {
        //        _db.Persons.Remove(persons);
        //        _db.SaveChanges();
        //        LoadData();
        //    }
        //}


        //private void AddTrip_Click(object sender, RoutedEventArgs e)
        //{
        //    //var form = new BusinessTripForm(_db.BusinessTrips.ToList());
        //    //if (form.ShowDialog() == true)
        //    //{
        //    //    _db.BusinessTrips.Add(form.Trip);
        //    //    _db.SaveChanges();
        //    //    LoadData();
        //    //}
        //}

        //private void EditTrip_Click(object sender, RoutedEventArgs e)
        //{
        //    //var id = (int)((Button)sender).Tag;
        //    //var trip = _db.BusinessTrips.Find(id);
        //    //var form = new BusinessTripForm(trip, _db.BusinessTrips.ToList());
        //    //if (form.ShowDialog() == true)
        //    //{
        //    //    _db.SaveChanges();
        //    //    LoadData();
        //    //}
        //}

        //private void DeleteTrip_Click(object sender, RoutedEventArgs e)
        //{
        //    var id = (int)((Button)sender).Tag;
        //    var trip = _db.BusinessTrips.Find(id);

        //    if (MessageBox.Show("Удалить командировку?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
        //    {
        //        _db.BusinessTrips.Remove(trip);
        //        _db.SaveChanges();
        //        LoadData();
        //    }
        //}
    }

}
