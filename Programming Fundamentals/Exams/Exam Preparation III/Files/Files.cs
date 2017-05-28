using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//var regex = new Regex(@"[a-zA-Z]+\.[a-zA-Z]+;\d+");
//var match = regex.Match(fileWithSize);
namespace Files
{
    public class Files
    {
        public static void Main()
        {
            var numbers = int.Parse(Console.ReadLine());
            var files = new Dictionary<string, Dictionary<string, long>>();
            for (int i = 0; i < numbers; i++)
            {
                var path = Console.ReadLine().Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var root = path[0];
                var fileWithSize = path[path.Length - 1].Split(';');
                var fileWithExtension = fileWithSize[0];
                var size = long.Parse(fileWithSize[1]);
                var extension = fileWithExtension.Split('.').Last().ToString();

                if (!files.ContainsKey(root))
                {
                    files[root] = new Dictionary<string, long>();
                }

                if (!files[root].ContainsKey(fileWithExtension))
                {
                    files[root][fileWithExtension] = 0;
                }

                files[root][fileWithExtension] = size;
            }

            var print = Console.ReadLine().Split();
            var type = print[0];
            var folder = print[print.Length - 1];

            if (files.ContainsKey(folder))
            {
                var foundFiles = files[folder];
                foreach (var file in foundFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (file.Key.EndsWith(type))
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
