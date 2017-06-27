using System;

namespace Boolean_Variable
{
    public class BooleanVariable
    {
        public static void Main()
        {
            string boolean = Console.ReadLine();
            bool isTrue = Convert.ToBoolean(boolean);
            if (isTrue == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
