void CoordinatesSearch(int X, int Y)
{
    if (X== 0 || Y== 0)
    {
        System.Console.WriteLine("Параметры не корректны");
    }
    else
    {
        if (X > 0 && Y > 0)
        {
            Console.WriteLine("1");
        }
        if (X > 0 && Y < 0)
        {
            Console.WriteLine("4");
        }
        if (X < 0 && Y > 0)
        {
            Console.WriteLine("2");
        }
        if (X < 0 && Y < 0)
        {
            Console.WriteLine("3");
        }
    }
}
CoordinatesSearch(2, -2);
CoordinatesSearch(-2, -2);
CoordinatesSearch(-2, 2);
CoordinatesSearch(0, 0);
CoordinatesSearch(2, 2);

