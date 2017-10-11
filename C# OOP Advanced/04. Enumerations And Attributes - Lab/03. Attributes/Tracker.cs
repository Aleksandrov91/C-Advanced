using System;
using System.Linq;
using System.Reflection;

public class Tracker
{
    public static void PrintMethodsByAuthor()
    {
        var type = typeof(StartUp);
        var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

        foreach (var methodInfo in methods)
        {
            if (methodInfo.CustomAttributes.Any(a => a.AttributeType == typeof(SoftUniAttribute)))
            {
                var attrs = methodInfo.GetCustomAttributes(false);

                foreach (SoftUniAttribute attrr in attrs)
                {
                    Console.WriteLine($"{methodInfo.Name} is written by {attrr.Name}");
                }
            }
        }
    }
}