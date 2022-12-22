// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void printQuarter(int a, int b)
{
    if (a>0 && b>0)
    {
        Console.WriteLine ("Первая четверть");
    }
    else if (a<0 && b>0)
    {
        Console.WriteLine ("Вторая четверть");
    }
    else if (a<0 && b<0)
    {
        Console.WriteLine ("Третья четверть");
    }
    else if (a>0 && b<0)
    {
        Console.WriteLine ("Четвертая четверть");
    }
    else
    {
        Console.WriteLine ("Определить четверть не возможно");
    }
}

