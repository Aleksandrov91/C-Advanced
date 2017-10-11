using System;

namespace Different_Integers_Size
{
    public class DifferentIntegersSize
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string dataType = string.Empty;

            long longVal;

            //if (!long.TryParse(input, out longVal))
            //{
            //    Console.WriteLine($"{input} can't fit in any type.");
            //    return;
            //}

            try
            {
                sbyte sbyteVal;
                sbyte.TryParse(input, out sbyteVal);
                dataType += "* sbyte\n";
            }

            catch (Exception)
            {
            }
            try
            {
                byte byteVal;
                byte.TryParse(input, out byteVal);
                dataType += "* byte\n";
            }

            catch (Exception)
            {
            }
            try
            {
                short shortVal;
                short.TryParse(input, out shortVal);
                dataType += "* short\n";
            }
            catch (Exception)
            {
            }
            try
            {
                ushort ushortVal;
                ushort.TryParse(input, out ushortVal);
                dataType += "* ushort\n";
            }
            catch (Exception)
            {
            }
            try
            {
                int intVal;
                int.TryParse(input, out intVal);
                dataType += "* int\n";
            }
            catch (Exception)
            {
            }
            try
            {
                uint uintVal;
                uint.TryParse(input, out uintVal);
                dataType += "* uint\n";
            }
            catch (Exception)
            {
            }
            try
            {
                long.TryParse(input, out longVal);
                dataType += "* long\n";
            }
            catch (Exception)
            {
            }
            Console.WriteLine($"{input} can fit in:");
            Console.Write(dataType);
        }
    }
}
