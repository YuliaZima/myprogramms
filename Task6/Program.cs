int Number = new Random().Next(100,1000);
System.Console.WriteLine(Number);

int NumberA = Number%10;
int NumberB = Number/100;

Console.Write(NumberB);
Console.Write(NumberA);
