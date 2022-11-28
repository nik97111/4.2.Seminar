// Задайте значение N. Напишите программу, которая выведет все 
// чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"


Console.Write("Введите целое положительное число N: ");
int N = int.Parse(Console.ReadLine());

void Numbers (int N)
{
    if ((N % 2) == 0)
    {
        Console.WriteLine(N);
    }
    if (N > 1)
    {
        Numbers(N - 1);
    }
}

Numbers(N);




