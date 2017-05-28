using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Or_Vegetable_switch
{
    class FruitOrVegetable
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            switch (n)
            {
                case "apple":
                    Console.WriteLine("Fruit");
                    break;
                case "banana":
                    Console.WriteLine("Fruit");
                    break;
                case "kiwi":
                    Console.WriteLine("Fruit");
                    break;
                case "cherry":
                    Console.WriteLine("Fruit");
                    break;
                case "lemon":
                    Console.WriteLine("Fruit");
                    break;
                case "grapes":
                    Console.WriteLine("Fruit");
                    break;
                case "tomato":
                    Console.WriteLine("Vegetable");
                    break;
                case "cucumber":
                    Console.WriteLine("Vegetable");
                    break;
                case "pepper":
                    Console.WriteLine("Vegetable");
                    break;
                case "carrot":
                    Console.WriteLine("Vegetable");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }
        }
    }
}
