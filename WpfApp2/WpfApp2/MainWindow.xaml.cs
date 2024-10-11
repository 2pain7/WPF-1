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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show ("Кнопка зажата");
        }

        private void Check_Checked(object sender, RoutedEventArgs e)
        {
            if (Check.IsChecked == true)
                MessageBox.Show("Is checked == true");
        }

        private void ZD_Checked(object sender, RoutedEventArgs e)
        {

            if (ZD.IsChecked == true)

                MessageBox.Show("with ZD");
        }

        private void DVD_Checked(object sender, RoutedEventArgs e)
        {
            if (DVD.IsChecked == true)

                MessageBox.Show("with DVD");
        }

        private void OS_Checked(object sender, RoutedEventArgs e)
        {
            if (OS.IsChecked == true)

                MessageBox.Show("for OS");
        }
    }
}
