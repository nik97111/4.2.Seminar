// Задайте двухмерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4 
// 0,5 7 -2 -0,2 
// 1 -3,3 8 -9,9  
// 8 7,8 -7,1 9


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random random = new Random();
            result[i, j] = random.NextDouble() * 10;
            if (random.Next(0, 2) == 1) 
            {
                result[i, j] *= -1;
            }
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,5:f1}", inArray[i, j])); 
        }
        Console.WriteLine();
    }
}