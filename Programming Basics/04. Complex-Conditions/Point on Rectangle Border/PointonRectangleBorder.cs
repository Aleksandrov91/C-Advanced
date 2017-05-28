using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_on_Rectangle_Border
{
    class PointonRectangleBorder
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var isLeftSide = x == x1 && y >= y1 && y <= y2;
            var isRightSide = x == x2 && y >= y1 && y <= y2;
            var isTopSide = y == y1 && x >= x1 && x <= x2;
            var isBottomSide = y == y2 && x >= x1 && x <= x2;

            if (isBottomSide || isLeftSide || isRightSide || isTopSide)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
