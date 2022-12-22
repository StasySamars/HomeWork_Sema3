/* Напишите программу, которая принимает 
на вход пятизначное число и проверяет, является ли 
оно палиндромом.
 */


Console.Clear();

Console.Write("Введите 5значное число: ");
string? number = Console.ReadLine();

if (number.Length != 5)
{
    Console.WriteLine($"Введи правильное число");
}
else if (number[0] == number[4] || number[1] == number[3])
{
    Console.WriteLine($"Ваше число: {number} - палиндром.");
}
else
{
    Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}
