using System;

public class Scale<T>
    where T : IComparable<T>
{
    private T first;
    private T second;

    public Scale(T first, T second)
    {
        this.first = first;
        this.second = second;
    }

    public T GetHavier()
    {
        if (this.first.CompareTo(this.second) > 0)
        {
            return first;
        }
        else if (this.second.CompareTo(this.first) > 0)
        {
            return second;
        }

        return default(T);
    }
}