using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string InputCurrency = Console.ReadLine();
            string OutputCurrency = Console.ReadLine();
            var lev = 1.0;
            var euro = 1.95583;
            var dollar = 1.79549;
            var pound = 2.53405;
            switch(InputCurrency)
            {
                case "BGN":
                    break;
                case "USD":
                    value = (value * dollar);
                    break;
                case "GBP":
                    value = (value * pound);
                    break;
                case "EUR":
                    value = (value * euro);
                    break;
                default:
                    break;
            }
            switch(OutputCurrency)
            {
                case "BGN":
                    value = (value / lev);
                    break;
                case "USD":
                    value = (value / dollar);
                    break;
                case "GBP":
                    value = (value / pound);
                    break;
                case "EUR":
                    value = (value / euro);
                    break;
                default:
                    break;
            }
            Console.WriteLine("{0} {1}", Math.Round(value, 2),OutputCurrency);
        }
    }
}
