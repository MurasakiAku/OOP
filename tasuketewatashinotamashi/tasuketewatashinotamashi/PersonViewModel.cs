using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using tasuketewatashinotamashi.Models;


namespace tasuketewatashinotamashi
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private readonly IPersonRepository _repository;
        private ObservableCollection<Person> _employees;
        private Person _selectedEmployee;

        public ObservableCollection<Person> Persons
        {
            get => _person;
            set
            {
                _employees = value;
                OnPropertyChanged();
            }
        }

        public Person SelectedPerson
        {
            get => _selectedPerson;
            set
            {
                _selectedPerson = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Position> Positions { get; }
        public ObservableCollection<Organisation> Organisations { get; }
        public ObservableCollection<Speciality> Specialities { get; }

        public ICommand AddCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand ClearCommand { get; }

        public PersonViewModel(IPersonRepository repository)
        {
            _repository = repository;
            LoadEmployees();

            Positions = new ObservableCollection<Position>(_repository.GetAllPositions());
            Organisations = new ObservableCollection<Organisation>(_repository.GetAllDepartments());
            Specialities = new ObservableCollection<Speciality>(_repository.GetAllSpecializations());

            AddCommand = new RelayCommand(AddPerson);
            UpdateCommand = new RelayCommand(UpdatePerson, CanExecute);
            DeleteCommand = new RelayCommand(DeletePerson, CanExecute);
            ClearCommand = new RelayCommand(ClearFields);
        }

        private void LoadEmployees()
        {
            Persons = new ObservableCollection<Person>(_repository.GetAll());
        }

        private void AddEmployee(object obj)
        {
            if (SelectedPerson == null) return;

            _repository.Add(SelectedPerson);
            LoadEmployees();
            ClearFields(null);
        }

        private void UpdateEmployee(object obj)
        {
            if (SelectedPerson == null) return;

            _repository.Update(SelectedPerson);
            LoadEmployees();
        }

        private void DeleteEmployee(object obj)
        {
            if (SelectedPerson == null) return;

            _repository.Delete(SelectedPerson.PersonId);
            LoadEmployees();
            ClearFields(null);
        }

        private void ClearFields(object obj)
        {
            SelectedPerson = new Person();
        }

        private bool CanExecute(object obj)
        {
            return SelectedPerson != null && SelectedPerson.PersonId != 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
