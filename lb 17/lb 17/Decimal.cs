using System;

class Decimal : Integer
{
    public Decimal(int[] digits) : base(digits)
    {
    }

    public override int ToInt()
    {
        int number = 0;

        foreach (int d in digits)
        {
            number = number * 10 + d;
        }

        return number;
    }
}