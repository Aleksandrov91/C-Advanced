using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenate_Data
{
    class ConcatenateData
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your firstname:");
            var firstname = Console.ReadLine();
            Console.Write("Enter your lastname:");
            var lastname = Console.ReadLine();
            Console.Write("Enter your age:");
            var age = Console.ReadLine();
            Console.Write("Enter your town:");
            var town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}- years old person from {3}.", firstname, lastname, age, town);
        }
    }
}
