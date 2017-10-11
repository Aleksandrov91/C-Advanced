using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Replace_a_tag
{
    public class ReplaceTag
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @" < a.*? href.*?= (.*) > (.*?) <\/ a > ";
            var replace = @"[URL href=$1]$2[/URL]";
            var replaced = Regex.Replace(text, pattern, replace);
            Console.WriteLine(replaced);

        }
    }
}
