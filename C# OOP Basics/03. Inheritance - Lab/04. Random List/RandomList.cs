using System;
using System.Collections;
using System.Collections.Generic;

public class RandomList : ArrayList
{
    private Random random;
    private List<string> data;

    public RandomList(List<string> data)
    {
        this.random = new Random();
        this.data = data;
    }

    public string RandomString()
    {
        int element = this.random.Next(0, this.data.Count - 1);
        string str = this.data[element];
        this.data.Remove(str);
        return str;
    }
}
