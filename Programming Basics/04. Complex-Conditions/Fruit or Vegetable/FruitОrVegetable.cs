using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class FruitОrVegetable
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine().ToLower();

            if (n == "banana" || n == "kiwi" || n == "apple" || n == "cherry" || n == "lemon" || n == "grapes")
            {
                Console.WriteLine("Fruit");
            }
            else if (n == "tomato" || n == "cucumber" || n == "pepper" || n == "carrot")
            {
                Console.WriteLine("Vegetable");
            }
            else
            {
                Console.WriteLine("Unknown");
            }
        }
    }
}
