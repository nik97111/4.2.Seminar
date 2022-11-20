// Задайте прямоугольный двухмерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1-я строка


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());


int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine($"{PrintArrayEL(array) + 1}-я строка");

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
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int PrintArrayEL(int[,] inArray) 
{
    var minI = 0;
    var min = 0;
    for (int i = 0; i < inArray.GetLength(0); i++ ) 
    {
        var sumRow = 0;
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
            sumRow += inArray[i, j];
        }
        if (sumRow < min) {
            min = sumRow;
            minI = i;
        }
    }
    return minI;
}
