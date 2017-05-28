using System;

namespace Master_Number
{
    public class MasterNumber
    {
        public static void Main()
        {
            int endNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endNum; i++)
            {
                if (IsPalindrome(i) == true && GetSumOfDigits(i) == true && ContainsEvenDigit(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsPalindrome(int index)
        {
            string digits = string.Empty + index;
            for (int i = 0; i < digits.Length / 2; i++)
            {
                if (digits[i] != digits[digits.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
            //int lastDigit = 0;
            //int reverse = 0;
            //int count = index;
            //while (count > 0)
            //{
            //    lastDigit = count % 10;
            //    reverse = reverse * 10 + lastDigit;
            //    count = count / 10;
            //}
            //if (reverse == index)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public static bool GetSumOfDigits(int index)
        {
            int sum = 0;
            int lastDigit = 0;
            while (index > 0)
            {
                lastDigit = index % 10;
                sum += lastDigit;
                index = index / 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }

            return false;
        }

        public static bool ContainsEvenDigit(int index)
        {
            int lastDigit = 0;
            while (index > 0)
            {
                lastDigit = index % 10;
                if (lastDigit % 2 == 0)
                {
                    return true;
                }

                index = index / 10;
            }

            return false;
        }
    }
}
