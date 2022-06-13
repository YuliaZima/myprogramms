int a = 16;
int b = 160;
int max;
int min;
if (a > b)
{
    max = a;
    min = b;
    Console.WriteLine($"{max} - большее, {min} - меньшее");
}
else if (a < b)
{
    max = b;
    min = a;
    Console.WriteLine($"{max} - большее, {min} - меньшее");
}
else
{
Console.WriteLine("Числа равны равны между собой ");
}
