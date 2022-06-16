void Polyndrome(int Number)
{
    if (Number > 9999 && Number < 100000)
    {
        int last = Number % 10;
        int first = Number / 10000;
        int second = (Number / 1000) % 10;
        int secondToLast = (Number / 10) % 10;
        if (first == last && second == secondToLast)
        {
            System.Console.WriteLine($"{Number} - полиндром");
        }
        else
        {
            System.Console.WriteLine($"{Number} - не полиндром");
        }
    }
    else
    {
        System.Console.WriteLine("Число не пятизначное");
    }

}
Polyndrome(23432);
Polyndrome(33432);
Polyndrome(22222);
Polyndrome(222222);
Polyndrome(111);