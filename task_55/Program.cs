// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
PrintArrayEl(array);
Console.WriteLine();
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
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

// void PrintArrayEl(int[,] inArray) {
//     int top = 0;
//     int bottom = inArray.GetLength(0) - 1;

//     for (int j = 0; j < inArray.GetLength(1); j++) 
//     {
//         int tmp = inArray[top, j];
//         inArray[top, j] = inArray[bottom, j];
//         inArray[bottom, j] = tmp;
//     }
// }

void PrintArrayEl(int[,] inArray) 
{
    //int[,] transform = new int[rows, columns];
    
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
            //transform [i = j, j = i];
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}