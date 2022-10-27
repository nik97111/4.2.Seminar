// Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());


int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
PrintArrayEl(array, rows, columns);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return arr;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}


void PrintArrayEl(int[,] arr, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        double sumElColumn = 0;
        double averageElsColumn = 0;

        for (int j = 0; j < columns; j++)
        {
            sumElColumn += arr[j, i];
            averageElsColumn = sumElColumn /columns;
        }
        Console.WriteLine("Сумма элементов в {0} столбце = {1}", i, sumElColumn);
        Console.WriteLine("Среднее арифметическое элементов {0} столбца = {1}", i, averageElsColumn);
    }
}



