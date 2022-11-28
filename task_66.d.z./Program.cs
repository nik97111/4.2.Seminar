// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

var sum = 0;

if (M < N)
{
    for (int i = M; i <= N; i++)
    {
        Console.Write($" {i}");
        sum += i;
    }
}
else
{
    for (int i = N; i <= M; i++)
    {
        Console.Write($" {i}");
        sum += i;
    }
}
Console.WriteLine();
Console.WriteLine(sum);



       