/* Напишите программу, которая по 
заданному номеру четверти, показывает диапазон возможных координат 
точек в этой четверти (x и y).*/

Console.Clear();
Console.WriteLine("Введите номер четверти");

int number = Convert.ToInt32(Console.ReadLine());


if (number == 1)
{
    Console.WriteLine("То X и Y будут иметь значения больше 0");
}
if (number == 2)
{
    Console.WriteLine("То X будет с отицательным знаком, а Y будет иметь положительный знак");
}
if (number == 3)
{
    Console.WriteLine("То X и Y будут иметь значения больше 0");
}
if (number == 4)
{
    "То X будет с положительным знаком, а Y будет иметь отрицательный знак";
}

// // Вариант решения через SWITCH

// Напишите программу, которая по заданному номеру четверти,
// // показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.Write("Введите номер четверти: ");
// int quarter = int.Parse(Console.ReadLine());

// switch (quarter)
// {
//     case 1:
//     {
//         Console.WriteLine("x>0 y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("x<0 y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("x<0 y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("x>0 y<0");
//         break;
//     }

//     default:
//     {
//         Console.WriteLine("Введена неправильная четверть");
//         break;
//     }
// }
