using System;

namespace ExchangeVariableValues
{
    public class ExchangeVariableValues
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}");
            int oldA = a;
            a = b;
            b = oldA;            
            Console.WriteLine($"After:\r\na = {a}\r\nb = {b}");
        }
    }
}
