void SquareOfNumber(int a)
{
    for (double i = 1; i <= a; i++)
    {
        double C = Math.Pow(i, 2);
        Console.WriteLine(C);
    }
}

SquareOfNumber(0);