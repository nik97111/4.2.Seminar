// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());


int SumNumbers(int M, int N)
{
    if (M == N)
    {
        return M;
    }

    return M + SumNumbers(M + 1, N);
}

int res = SumNumbers(M, N);
Console.WriteLine(res);