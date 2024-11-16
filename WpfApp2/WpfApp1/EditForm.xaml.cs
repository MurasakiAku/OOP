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
using System.Windows.Shapes;
using static WpfApp2.BD;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для EditForm.xaml
    /// </summary>
    public partial class EditForm : Window
    {
        public EditForm()
        {
            InitializeComponent();
        }

        

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
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

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
