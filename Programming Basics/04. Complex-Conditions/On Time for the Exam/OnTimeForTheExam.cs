using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMin = int.Parse(Console.ReadLine());
            var arriveHour = int.Parse(Console.ReadLine());
            var arriveMin = int.Parse(Console.ReadLine());
            var examTimeMin = (60 * examHour) + examMin;
            var arriveexamTimeMin = (60 * arriveHour) + arriveMin;
            var difference = Math.Abs(arriveexamTimeMin - examTimeMin);
            int hh = difference / 60;
            int mm = difference % 60;

            if (examTimeMin < arriveexamTimeMin)
            {
                Console.WriteLine("Late");
                if (difference < 60)
                {
                    Console.WriteLine("{0} minutes after the start", mm);
                }
                else
                {
                    if (mm < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours after the start", hh, mm);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours after the start", hh, mm);
                    }
                }
            }
            else
            {
                if (difference == 0)
                {
                    Console.WriteLine("On time");
                }
                else if (difference <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", mm);
                }
                else
                {
                    Console.WriteLine("Early");
                    if (difference < 60)
                    {
                        Console.WriteLine("{0} minutes before the start", mm);
                    }
                    else
                    {
                        if (mm < 10)
                        {
                            Console.WriteLine("{0}:0{1} hours before the start", hh, mm);
                        }
                        else
                        {
                            Console.WriteLine("{0}:{1} hours before the start", hh, mm);
                        }
                    }
                }
            }
        }
    }
}
