// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3 в 5-й степени),  2, 4 -> 16 (2 в 4-й степени)



// Console.Write("Введите число A: ");
// int numA = int.Parse(Console.ReadLine());
// Console.Write("Введите число B: ");
// int numB = int.Parse(Console.ReadLine());

// int order = numB;
// Console.WriteLine(Math.Pow(numA, order));




Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine());

int order = numB;
if (numA > 0 && numB > 0)
{
    Console.WriteLine($"Число А в степени числа B = " + Math.Pow(numA, order));
} 
else 
{
    Console.WriteLine("Введите число больше 0 ");
}