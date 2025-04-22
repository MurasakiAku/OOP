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
    /// Логика взаимодействия для BusinessTripForm.xaml
    /// </summary>
    public partial class BusinessTripForm : Window
    {
        public BusinessTrip BusinessTrip { get; private set; }
        BusinessTrip _businesstrip;
        MyDbContext _db;
       
        public BusinessTripForm(MyDbContext db, BusinessTrip businesstrip)
        {
            _db = db;
            _businesstrip = businesstrip;
            InitializeComponent();
            BusinessTrip = new BusinessTrip();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(BusinessTrip.) ||
            //    string.IsNullOrWhiteSpace(BusinessTrip.Purpose))
                

            //{
            //    MessageBox.Show("Заполните обязательные поля!");
            //    return;
            //}

            //DialogResult = true;
            //Close();
        }

        //private void Cancel_Click(object sender, RoutedEventArgs e)
        //{
        //    DialogResult = false;
        //    Close();
        //}
    }
}
