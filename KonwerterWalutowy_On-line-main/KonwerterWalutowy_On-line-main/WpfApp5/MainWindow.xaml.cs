using System;
using System.Xml;
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

namespace KonwerterWalutowy
{

    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CurrencyConverter ConvertPLN { get; set; }
        public MainWindow()
        {
            ConvertPLN = new CurrencyConverter();
            InitializeComponent();
            this.textbox1.PreviewTextInput += new TextCompositionEventHandler(textBox_PreviewTextInput);

        }
        public void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {            
            ConvertPLN.LoadDictionary();           
            block1.Text = "Aktualny kurs walut na dzień " + System.DateTime.Now + "\n\n USD: " 
                          + ConvertPLN.ShowRate("USD") + "\n CZK: " + ConvertPLN.ShowRate("CZK") + "\n EUR: "
                          + ConvertPLN.ShowRate("EUR") + "\n GBP: " + ConvertPLN.ShowRate("GBP") + "\n HUF: " 
                          + ConvertPLN.ShowRate("HUF") + "\n\nDane zostały pomyślnie pobrane z serwera NBP";   
            
            label1.IsEnabled = true;
            textbox1.IsEnabled = true;
            button2.IsEnabled = true;
            USDradioButton.IsEnabled = true;
            EURradioButton.IsEnabled = true;
            CZKradioButton.IsEnabled = true;
            GBPradioButton.IsEnabled = true;
            HUFradioButton.IsEnabled = true;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           if (GBPradioButton.IsChecked == true) LabelResult.Content = textbox1.Text + " GBP = " + ConvertPLN.ConverTo(double.Parse(textbox1.Text), "GBP").ToString() + " PLN";
           if (USDradioButton.IsChecked == true) LabelResult.Content = textbox1.Text + " USD = " + ConvertPLN.ConverTo(double.Parse(textbox1.Text), "USD").ToString() + " PLN";
           if (EURradioButton.IsChecked == true) LabelResult.Content = textbox1.Text + " EUR = " + ConvertPLN.ConverTo(double.Parse(textbox1.Text), "EUR").ToString() + " PLN";
           if (CZKradioButton.IsChecked == true) LabelResult.Content = textbox1.Text + " CZK = " + ConvertPLN.ConverTo(double.Parse(textbox1.Text), "CZK").ToString() + " PLN";
           if (HUFradioButton.IsChecked == true) LabelResult.Content = textbox1.Text + " HUF = " + ConvertPLN.ConverTo(double.Parse(textbox1.Text), "HUF").ToString() + " PLN";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
