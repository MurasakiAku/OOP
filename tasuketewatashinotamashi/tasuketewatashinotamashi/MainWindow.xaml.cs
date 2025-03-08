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
        MyDbContext MyDbContext = new MyDbContext();
        public MainWindow()
        {
            InitializeComponent();
            MyDbContext.Database.EnsureCreated();
            MyDbContext.Persons.Load();
            MyDbContext.Persons.Local.ToObservableCollection();
            

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
