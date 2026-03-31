using System;

class Binary : Integer
{
    public Binary(int[] digits) : base(digits)
    {
    }

    public override int ToInt()
    {
        int number = 0;

        foreach (int d in digits)
        {
            number = number * 2 + d;
        }

        return number;
    }
}