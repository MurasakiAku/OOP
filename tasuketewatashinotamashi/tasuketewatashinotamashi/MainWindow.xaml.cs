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
           
        }
       
    }

}
