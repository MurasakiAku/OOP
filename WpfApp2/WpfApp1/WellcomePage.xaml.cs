using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp2.DataAccess;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для WellcomePage.xaml
    /// </summary>
    public partial class WellcomePage : Window
    {
        AppContex db;
        public WellcomePage()
        {
            InitializeComponent();

            db = new AppContex();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LookPage lookPage = new LookPage();
            lookPage.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.Show();
        }
        
    }
}
