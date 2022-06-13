int a = 81;
int b = 81;
int c = 81;
int max = a;
if (max < b || max < c)
{
    max = b;
    max = c;
    Console.Write($" Максимальное значение - {max}");
}
else
{
    if (a == b && a == c && b == c)
    {
        System.Console.Write($"Числа равны между собой.");
    }
    else
    {
        Console.Write($" Максимальное значение - {max}");
    }
}

