using System;

public class Startup
{
    public static void Main()
    {
        var scale = new Scale<string>("3", "3");
        Console.WriteLine(scale.GetHavier());
    }
}