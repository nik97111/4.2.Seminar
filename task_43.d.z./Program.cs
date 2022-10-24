// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями: y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.Write("Введите значение b1: ");
// double b1 = int.Parse(Console.ReadLine());
// Console.Write("Введите значение k1: ");
// double k1 = int.Parse(Console.ReadLine());
// Console.Write("Введите значение b2: ");
// double b2 = int.Parse(Console.ReadLine());
// Console.Write("Введите значение k2: ");
// double k2 = int.Parse(Console.ReadLine());


// double x = (b2 - b1) / (k1 - k2);
// Console.WriteLine($"Точка х = {x}");
// double y = k2 * x + b2;
// Console.WriteLine($"Координаты точки пересечения двух прямых: {x}; {y}");



// if (k1 != k2)
// {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = k2 * x + b2;
//     Console.WriteLine($"Координаты точки пересечения двух прямых: {x}; {y}");
// }
// else 
// {
//     Console.WriteLine("Значения -k- не должны совпадать");
// }



double b1 = GetValues();
double k1 = GetValues();
double b2 = GetValues();
double k2 = GetValues();
PrintValuesCoordinates(b1, k1, b2, k2);


double GetValues()
{
    Console.Write("Введите значение: ");
    double value = int.Parse(Console.ReadLine());
    return value;
}

void PrintValuesCoordinates(double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Координаты точки пересечения двух прямых: {x}; {y}");
    }    
    else
    {
        Console.WriteLine("Значения -k- не должны совпадать");
    }
}
