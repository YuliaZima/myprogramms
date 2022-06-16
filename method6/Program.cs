void CubeTab(int a)
{
    for (double i = 1; i <= a; i++)
    {

        double C = Math.Pow(i, 3);
        Console.WriteLine(C);
    }
}
CubeTab(5);