﻿//Определить, является ли введенное число или слово палендромом.

Console.Clear();

Console.Write("Введите любое число или слово: ");
string num = Console.ReadLine();
int numTxt = num.Length;

for (int i = 1; i < numTxt; i++)
{
    if (num[i - 1] != num[numTxt - (i)])
    {
        Console.WriteLine("не палиндром!");
        break;
    }
    if (i == numTxt-1)
    {
        Console.WriteLine("палиндром!");
        break;
    }
}