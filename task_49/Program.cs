// Задайте двумерный массив. Найдите элементы, у которых оба индекса 
// четные и замените эти элеменнты на их квадраты.


// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] arr = new int[rows, columns];
// FillArray(arr, rows, columns, 0, 10);
// PrintArray(arr);
// ProcessArray(arr, rows, columns);
// PrintArray(arr);

// void FillArray(int[,] arr, int m, int n, int minValue, int maxValue)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             arr[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
// }

// void ProcessArray(int[,] arr, int m, int n)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             if ((i % 2 == 0) && (j % 2 == 0))
//             {
//                 arr[i, j] *= arr[i, j];
//             }
//         }
//     }
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




Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());


int[,] array = FillArray(rows, columns, 0, 10);
GetArray(array, rows, columns);
PrintArray(array);

int[,] FillArray(int m, int n, int minValue, int maxValue)
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

void GetArray(int[,] arr, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                arr[i, j] *= arr[i, j];
            }
        }
    }
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


