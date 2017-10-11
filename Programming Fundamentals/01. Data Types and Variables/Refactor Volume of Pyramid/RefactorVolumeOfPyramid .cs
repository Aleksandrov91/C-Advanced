using System;

namespace Refactor_Volume_of_Pyramid
{
    public class Program
    {
        public static void Main()
        {
            double lenght, width, heigh, volume = 0;
            Console.Write("Length: ");
            lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            heigh = double.Parse(Console.ReadLine());
            volume = (lenght * width * heigh) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
