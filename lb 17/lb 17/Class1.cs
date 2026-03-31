using System;

abstract class Integer
{
    protected int[] digits;

    public Integer(int[] digits)
    {
        this.digits = digits;
    }

    public abstract int ToInt();

    public string Print()
    {
        string s = "";

        foreach (int d in digits)
        {
            s += d;
        }

        return s;
    }

    public int Add(Integer other)
    {
        return this.ToInt() + other.ToInt();
    }

    public int Sub(Integer other)
    {
        return this.ToInt() - other.ToInt();
    }
}