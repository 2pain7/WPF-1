using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp14
{
    public partial class MainWindow : Window
    {
        private DrawingAttributes drawingAttributes;

        public MainWindow()
        {
            InitializeComponent();

            // Инициализация DrawingAttributes
            drawingAttributes = new DrawingAttributes();
            SetPenColor(Colors.Red);
            SetPenSize(1);
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (colorComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string colorName = selectedItem.Content.ToString();
                Color color = (Color)ColorConverter.ConvertFromString(colorName);
                SetPenColor(color);
            }
        }

        private void SetPenColor(Color color)
        {
            drawingAttributes.Color = color;
            Inkc.DefaultDrawingAttributes = drawingAttributes;
        }

        private void SizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SetPenSize(e.NewValue);
        }

        private void SetPenSize(double size)
        {
            drawingAttributes.Width = size;
            drawingAttributes.Height = size;
            Inkc.DefaultDrawingAttributes = drawingAttributes;
        }

        private void Art_Checked(object sender, RoutedEventArgs e)
        {
            Inkc.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void Edit_Checked(object sender, RoutedEventArgs e)
        {
            Inkc.EditingMode = InkCanvasEditingMode.Select;
        }

        private void Del_Checked(object sender, RoutedEventArgs e)
        {
            Inkc.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }
    }
}