﻿using Microsoft.EntityFrameworkCore;
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
    /// Логика взаимодействия для WellcomePage.xaml
    /// </summary>
    public partial class WellcomePage : Page
    {
        MyDbContext db = new MyDbContext();
        public WellcomePage()
        {
            InitializeComponent();
            db.Persons.ToArray();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow(db, null);
            window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //LookPage lookPage = new LookPage();
            //lookPage.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
