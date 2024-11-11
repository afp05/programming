using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KonwerterWalutowy
{
    public class CurrencyConverter
    {
        public Dictionary<string, Currency> CurrencyDictionary { get; set; }


        public bool LoadDictionary()
        {
            CurrencyDictionary = new Dictionary<string, Currency>();
            
            XmlDocument xml = new XmlDocument();
            try
            {
                xml.Load("https://www.nbp.pl/Kursy/xml/LastA.xml");
            }
            catch
            {
                MessageBox.Show("Błąd serwera NBP lub problem z połączeniem internet");
                Environment.Exit(1); 
                
            }
            XmlElement element = xml.DocumentElement;
            foreach (XmlNode node in element)
            {
              //  if (node.Name != "pozycja")
               //     continue;

                Currency currency = new Currency();

                currency.Name = node["nazwa_waluty"].InnerText;
                currency.Converter = int.Parse(node["przelicznik"].InnerText);
                currency.Code = node["kod_waluty"].InnerText;
                currency.Rate = double.Parse(node["kurs_sredni"].InnerText);
                CurrencyDictionary.Add(currency.Code, currency);
            }

            return true;
        }
        public double ConverTo(double val, string targetWaluta)
        {
            Currency c = CurrencyDictionary[targetWaluta];
            if (c != null)
            {
                return (val * c.Rate) / c.Converter;
            }
            return 0;
        }
        public double ShowRate(string targetWaluta)
        {
            Currency c = CurrencyDictionary[targetWaluta];
            return c.Rate/c.Converter;
        }
    }
}
