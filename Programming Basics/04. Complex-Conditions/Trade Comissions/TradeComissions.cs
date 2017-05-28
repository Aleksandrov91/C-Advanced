using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double commision = -1;

            if (sales <= 500)
            {
                if (city == "varna")
                {
                    commision = sales * 0.045;
                }
                else if (city == "sofia")
                {
                    commision = sales * 0.05;
                }
                else if (city == "plovdiv")
                {
                    commision = sales * 0.055;
                }
            }
            else if (sales > 500 && sales <= 1000)
            {
                if (city == "varna")
                {
                    commision = sales * 0.075;
                }
                else if (city == "sofia")
                {
                    commision = sales * 0.07;
                }
                else if (city == "plovdiv")
                {
                    commision = sales * 0.08;
                }
            }
            else if (sales > 1000 && sales <= 10000)
            {
                if (city == "varna")
                {
                    commision = sales * 0.1;
                }
                else if (city == "sofia")
                {
                    commision = sales * 0.08;
                }
                else if (city == "plovdiv")
                {
                    commision = sales * 0.12;
                }
            }
            else if (sales > 10000)
            {
                if (city == "varna")
                {
                    commision = sales * 0.13;
                }
                else if (city == "sofia")
                {
                    commision = sales * 0.12;
                }
                else if (city == "plovdiv")
                {
                    commision = sales * 0.145;
                }
            }
            if (commision >= 0)
            {
                Console.WriteLine("{0:f2}", commision);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
