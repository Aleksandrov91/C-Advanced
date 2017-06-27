using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.Simple_Text_Editor
{
    public class SimpleTextEditor
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var currentText = string.Empty;
            var lastStrings = new Stack<string>();
            lastStrings.Push(currentText);

            for (int i = 0; i < n; i++)
            {
                var args = Console.ReadLine().Split();

                var operation = args[0];

                switch (operation)
                {
                    case "1":
                        currentText += args[1];
                        lastStrings.Push(currentText);
                        break;
                    case "2":
                        var count = int.Parse(args[1]);
                        currentText = currentText.Remove(currentText.Length - count, count);
                        lastStrings.Push(currentText);
                        break;
                    case "3":
                        var element = int.Parse(args[1]);
                        Console.WriteLine(currentText[element - 1]);
                        break;
                    case "4":
                            lastStrings.Pop();
                            currentText = lastStrings.Peek();
                        break;
                }
            }
        }
    }
}
