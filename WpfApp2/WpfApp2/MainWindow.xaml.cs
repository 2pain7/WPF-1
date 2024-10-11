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

       

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Peshich D.; Версия: 0.0.1");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (Red.IsChecked == true)
            {
                Wind.Background = Brushes.LightPink ;
            }
        }

        private void Green_Checked(object sender, RoutedEventArgs e)
        {
            if (Green.IsChecked == true)
            {
                Wind.Background = Brushes.LightGreen;
            }
        }

        private void Blue_Checked(object sender, RoutedEventArgs e)
        {
            if (Blue.IsChecked == true)
            {
                Wind.Background = Brushes.LightBlue;
            }
        }
    }
}
