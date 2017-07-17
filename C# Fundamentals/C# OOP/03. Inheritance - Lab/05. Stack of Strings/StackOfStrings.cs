using System;
using System.Collections.Generic;

public class StackOfStrings
{
    private List<string> data;

    public void Push(string item)
    {
        this.data.Insert(0, item);
    }

    public string Pop()
    {
        var lastElement = this.Peek();
        this.data.Remove(lastElement);
        return lastElement;
    }

    public string Peek()
    {
        if (!this.IsEmpty())
        {
            string lastElement = this.data[this.data.Count - 1];
            return lastElement;
        }
        else
        {
            throw new NullReferenceException();
        }
    }

    public bool IsEmpty()
    {
        if (this.data.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
