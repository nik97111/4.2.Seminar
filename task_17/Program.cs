// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X != 0 и Y != 0 и выдает номер четверти плоскости, 
// в которй находится эта точка.

Console.WriteLine("Введите координаты точки X: ");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки Y: ");
int Y = int.Parse(Console.ReadLine());


if ((X != 0) && (Y != 0))
{
    if ((X > 0) && (Y > 0))
    {
        Console.WriteLine("Точка находится в плоскости 1");
    }

    if ((X < 0) && (Y > 0))
    {
        Console.WriteLine("Точка находится в плоскости 2");
    }

    if ((X < 0) && (Y < 0))
    {
        Console.WriteLine("Точка находится в плоскости 3");
    }

    if ((X > 0) && (Y < 0))
    {
        Console.WriteLine("Точка находится в плоскости 4");
    }
    else 
    { 
        Console.WriteLine("Введите координаты, не равные нулю");
    }
}