// Напишите программу, которая на вход принимает позиции элемента 
// в двухмерном массиве и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)


// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());

// Console.Write("Введите позицию строк элемента: ");
// int rowEl = int.Parse(Console.ReadLine());
// Console.Write("Введите позицию столбца элемента: ");
// int columnEl = int.Parse(Console.ReadLine());


// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// if ((rowEl < rows) && (columnEl < columns))
//     Console.WriteLine("Число с такой позицией в массиве есть");
// else 
//     Console.WriteLine("Числа с такой позицией в массиве нет");


// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] arr = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//            arr[i, j] = new Random().Next(minValue, maxValue); 
//         }
//     }
//     return arr;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());

// Console.Write("Введите позицию строк элемента: ");
// int rowEl = int.Parse(Console.ReadLine());
// Console.Write("Введите позицию столбца элемента: ");
// int columnEl = int.Parse(Console.ReadLine());


// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// PrintArrayEl(array, rows, columns);

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] arr = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//            arr[i, j] = new Random().Next(minValue, maxValue); 
//         }
//     }
//     return arr;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void PrintArrayEl(int[,] arr, int rows, int columns)
// {
//     if ((rowEl < rows) && (columnEl < columns))
//         Console.WriteLine("Число с такой позицией в массиве есть");
//     else 
//         Console.WriteLine("Числа с такой позицией в массиве нет");
// }


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите позицию строк элемента: ");
int rowEl = int.Parse(Console.ReadLine());
Console.Write("Введите позицию столбца элемента: ");
int columnEl = int.Parse(Console.ReadLine());


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
    if ((rowEl < rows) && (columnEl < columns))
        Console.WriteLine("Число: " + arr[rowEl, columnEl]);
    else
        Console.WriteLine("Числа с такой позицией в массиве нет");
}