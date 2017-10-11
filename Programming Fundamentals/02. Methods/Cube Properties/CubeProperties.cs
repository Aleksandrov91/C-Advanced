using System;

namespace Cube_Properties
{
    public class CubeProperties
    {
        public static void Main()
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            if (parameter == "face")
            {
                GetFaces(cubeSide);
            }
            else if (parameter == "space")
            {
                GetSpace(cubeSide);
            }
            else if (parameter == "volume")
            {
                GetVolume(cubeSide);
            }
            else if (parameter == "area")
            {
                GetArea(cubeSide);
            }
        }

        public static void GetFaces(double cubeSide)
        {
            double face = Math.Sqrt(2 * (Math.Pow(cubeSide, 2)));
            Console.WriteLine("{0:f2}", face);
        }

        public static void GetSpace(double cubeSide)
        {
            double space = Math.Sqrt(3 * (Math.Pow(cubeSide, 2)));
            Console.WriteLine("{0:f2}", space);
        }

        public static void GetVolume(double cubeSide)
        {
            double volume = Math.Pow(cubeSide, 3);
            Console.WriteLine("{0:f2}", volume);
        }

        public static void GetArea(double cubeSide)
        {
            double area = 6 * Math.Pow(cubeSide, 2);
            Console.WriteLine("{0:f2}", area);
        }
    }
}
