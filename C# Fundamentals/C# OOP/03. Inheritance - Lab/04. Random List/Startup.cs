using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        var list = new List<string>()
        {
            "edno",
            "dve",
            "tri",
            "chetiri"
        };

        var rndList = new RandomList(list);

        Console.WriteLine(rndList.RandomString());
    }
}
