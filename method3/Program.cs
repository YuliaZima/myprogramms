void Dotlocation (int a)
{
    if (a > 4)
    {
        Console.WriteLine("Параметры не корректны");
    }
    else
    {
        if (a == 1) 
    
        {
            Console.WriteLine ("X > 0, Y > 0");
        }
        if (a == 4)
        {
            Console.WriteLine("X > 0, Y < 0");
        }
        if (a == 2)
        {
            Console.WriteLine("X < 0, Y > 0");
        }
        if (a == 3)
        {
            Console.WriteLine("X < 0, Y < 0");
        }
    }
}
Dotlocation(1);
Dotlocation(2);
Dotlocation(3);
Dotlocation(4);