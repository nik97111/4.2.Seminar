// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
PrintArrayEl(array);
Console.WriteLine();
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue) {
    
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++ ) {
        for (int j = 0; j < n; j++) {
            arr[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return arr;
}

void PrintArray(int[,] inArray) {
    for (int i = 0; i < inArray.GetLength(0); i++ ) {
        for (int j = 0; j < inArray.GetLength(1); j++) {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArrayEl(int[,] inArray) {
    int top = 0;
    int bottom = inArray.GetLength(0) - 1;

    for (int j = 0; j < inArray.GetLength(1); j++) 
    {
        int tmp = inArray[top, j];
        inArray[top, j] = inArray[bottom, j];
        inArray[bottom, j] = tmp;
    }
}


// void PrintArrayEl(int[,] arr, int rows, int columns) {
//     // var tempFirstLine = [];
//     // var tempLastLine = [];
//     for (int i = 0; i < m; i++ ) {
//         for (int j = 0; j < n; j++) {
//             tempLastLine = [0, j];
//             tempFirstLine = [2, j];
//             Console.WriteLine(tempLastLine);
//             Console.WriteLine(tempFirstLine);
//         }
//     }
// }




// int[,] array = new int[5, 5];
// GetArray(array);
// PrintArray(array);

// void GetArray(int[,] arr) 
// {
//     for (int i = 0; i < arr.GetLength(0); i++ ) 
//     {
//         for (int j = 0; j < arr.GetLength(1); j++) 
//         {
//             arr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] arr) 
// {
//     for (int i = 0; i < arr.GetLength(0); i++ ) 
//     {
//         for (int j = 0; j < arr.GetLength(1); j++) 
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void ReverseString(int[,] arr) 
// {
//     int[,] newArray = new int[5, 5];
//     for (int i = 0; i < arr.GetLength(0); i++ ) 
//     {
//         for (int j = 0; j < arr.GetLength(1); j++) 
//         {
//             if (i == 0) 
//             {
//                 for (int k = 0; k < newArray.GetLength(0); k++ ) {
//                     for (int l = 0; l < newArray.GetLength(1); l++) {
//                         newArray[newArray.GetLength(0)-1, 1] = arr[i, GetLength(1)-1];
//                     }
//                 } 
//             }
//             if (i == 4) 
//             {
//                 for (int k = 0; k < newArray.GetLength(0); k++ ) 
//                 {
//                     for (int l = 0; l < newArray.GetLength(1); l++) 
//                     {
//                         newArray[newArray.GetLength(0)-1, 1] = arr[i, GetLength(1)-1];
//                     }
//                 } 
//             }
//         }
//     }
// }
