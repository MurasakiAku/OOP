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
using static WpfApp2.BD;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
            
        }

        
    }
}
