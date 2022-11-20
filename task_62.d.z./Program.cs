// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());


int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
FillArray(array);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++ ) 
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
    for (int i = 0; i < inArray.GetLength(0); i++ ) 
    {
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
            Console.Write($"{inArray[i, j].ToString("D2")} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] inArray) 
{
    inArray[0, 0] = 1;
    inArray[0, 1] = 2;
    inArray[0, 2] = 3;
    inArray[0, 3] = 4;

    inArray[1, 3] = 5;
    inArray[2, 3] = 6;
    inArray[3, 3] = 7;

    inArray[3, 2] = 8;
    inArray[3, 1] = 9;
    inArray[3, 0] = 10;

    inArray[2, 0] = 11;
    inArray[1, 0] = 12;

    inArray[1, 1] = 13;
    inArray[1, 2] = 14;

    inArray[2, 2] = 15;
    inArray[2, 1] = 16;
}