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
            LoadData();

        }
        private void LoadData()
        {
            _db.Persons
                .Include(p => p.Street).ThenInclude(s => s.City).ThenInclude(c => c.Country)
                .Load();

            PersonsGrid.ItemsSource = _db.Persons.Local.ToObservableCollection();
        }
        private void AddPerson_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new PersonEditDialog();
            if (dialog.ShowDialog() == true)
            {
                _db.Persons.Add(dialog.Person);
                _db.SaveChanges();
                LoadData();
            }
        }

        private void EditPerson_Click(object sender, RoutedEventArgs e)
        {
            if (PersonsGrid.SelectedItem is Person selectedPerson)
            {
                var dialog = new PersonEditDialog(selectedPerson);
                if (dialog.ShowDialog() == true)
                {
                    _db.SaveChanges();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void DeletePerson_Click(object sender, RoutedEventArgs e)
        {
            if (PersonsGrid.SelectedItem is Person selectedPerson)
            {
                var result = MessageBox.Show(
                    $"Are you sure you want to delete {selectedPerson.LastName} {selectedPerson.FirstName}?",
                    "Confirm Delete",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    _db.Persons.Remove(selectedPerson);
                    _db.SaveChanges();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void FilterComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Реализация фильтрации
            if (FilterComboBox.SelectedIndex == 0)
            {
                LoadData();
            }
            else if (FilterComboBox.SelectedIndex == 1)
            {
                PersonsGrid.ItemsSource = _db.Persons
                    .Local
                    .Where(p => p.BusinessTripId != null)
                    .ToList();
            }
        }

        private void PersonsGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Обновление деталей при выборе сотрудника
        }
    }

}


