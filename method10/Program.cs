﻿void Array()
{
    int[] Array = new int[8];
    for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(0, 2);
    Console.Write($"{Array[i]} ");
}
}
Array();
