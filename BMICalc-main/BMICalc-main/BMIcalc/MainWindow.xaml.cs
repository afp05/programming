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

namespace BMIcalc
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WeightBox.PreviewTextInput += new TextCompositionEventHandler(textBox_PreviewTextInput);
            this.HeightBox.PreviewTextInput += new TextCompositionEventHandler(textBox_PreviewTextInput);

        }
        void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MezczyznaRadioButton.IsChecked == true)
            {

                Mezczyzna man = new Mezczyzna(double.Parse(WeightBox.Text), double.Parse(HeightBox.Text));
                man.calculateBMI();
                Wynik.Text = man.message;
            }
            else
            {
                Kobieta koba = new Kobieta(double.Parse(WeightBox.Text), double.Parse(HeightBox.Text));
                koba.calculateBMI();
                Wynik.Text = koba.message;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {                   
               
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
