// Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.(Посмотрите как реализуется произведение 
// матриц, там не просто перемножение элемент на элемент).
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Write("Введите количество строк массива: "); 
int rows1 = int.Parse(Console.ReadLine()); 
Console.Write("Введите количество столбцов массива: "); 
int columns1 = int.Parse(Console.ReadLine()); 
 
Console.Write("Введите количество строк массива: "); 
int rows2 = int.Parse(Console.ReadLine()); 
Console.Write("Введите количество столбцов массива: "); 
int columns2 = int.Parse(Console.ReadLine()); 
 
 
int[,] arrayMatrix1 = GetArrayMatrix(rows1, columns1, 0, 10); 
int[,] arrayMatrix2 = GetArrayMatrix(rows2, columns2, 0, 10); 
PrintArray(arrayMatrix1); 
Console.WriteLine(); 
PrintArray(arrayMatrix2); 
Console.WriteLine(); 
int[,] arrayMultiplicationOfTwoMatrices = GetArraysMultiplication(arrayMatrix1, arrayMatrix2, rows1, rows2, columns1, columns2); 
PrintArray(arrayMultiplicationOfTwoMatrices); 
 
 
 
int[,] GetArrayMatrix(int m, int n, int minValue, int maxValue)  
{ 
    int[,] arr1 = new int[m, n]; 
    for (int i = 0; i < m; i++ )  
    { 
        for (int j = 0; j < n; j++)  
        { 
            arr1[i, j] = new Random().Next(minValue, maxValue); 
        } 
    } 
    return arr1; 
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
 
int[,] GetArraysMultiplication(int[,] arrayMatrix1, int[,] arrayMatrix2, int rows1, int rows2, int columns1, int columns2)  
{ 
    int[,] arrayMultiplication = new int[rows1, columns2]; 
 
    arrayMultiplication[0, 1] = (arrayMatrix1[0, 0] * arrayMatrix2[0, 1]) + 
    (arrayMatrix1[0, 1] * arrayMatrix2[1, 1]); 
 
    arrayMultiplication[0, 0] = (arrayMatrix1[0, 0] * arrayMatrix2[0, 0]) + 
    (arrayMatrix1[0, 1] * arrayMatrix2[1, 0]); 
 
    arrayMultiplication[1, 0] = (arrayMatrix1[1, 0] * arrayMatrix2[0, 0]) + 
    (arrayMatrix1[1, 1] * arrayMatrix2[1, 0]); 
 
    arrayMultiplication[1, 1] = (arrayMatrix1[1, 0] * arrayMatrix2[0, 1]) + 
    (arrayMatrix1[1, 1] * arrayMatrix2[1, 1]); 
 
 
    return arrayMultiplication; 
}



// Console.Write("Введите количество строк массива: ");
// int rows1 = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns1 = int.Parse(Console.ReadLine());

// Console.Write("Введите количество строк массива: ");
// int rows2 = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns2 = int.Parse(Console.ReadLine());


// int[,] arrayMatrix1 = GetArrayMatrix1(rows1, columns1, 0, 10);
// int[,] arrayMatrix2 = GetArrayMatrix2(rows2, columns2, 0, 10);
// PrintArray(arrayMatrix1);
// Console.WriteLine();
// PrintArray(arrayMatrix2);
// Console.WriteLine();
// int[,] arrayMultiplicationOfTwoMatrices = GetArraysMultiplication(arrayMatrix1, arrayMatrix2, rows1, rows2, columns1, columns2);
// PrintArray(arrayMultiplicationOfTwoMatrices);



// int[,] GetArrayMatrix1(int m, int n, int minValue, int maxValue) 
// {
//     int[,] arr1 = new int[m, n];
//     for (int i = 0; i < m; i++ ) 
//     {
//         for (int j = 0; j < n; j++) 
//         {
//             arr1[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return arr1;
// }

// void PrintArray(int[,] inArray) 
// {
//     for (int i = 0; i < inArray.GetLength(0); i++ ) 
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++) 
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }        


// int[,] GetArrayMatrix2(int m, int n, int minValue, int maxValue) 
// {
//     int[,] arr2 = new int[m, n];
//     for (int i = 0; i < m; i++ ) 
//     {
//         for (int j = 0; j < n; j++) 
//         {
//             arr2[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return arr2;
// }


// int[,] GetArraysMultiplication(int[,] arrayMatrix1, int[,] arrayMatrix2, int rows1, int rows2, int columns1, int columns2) 
// {
//     int[,] arrayMultiplication = new int[rows1, columns2];

//     arrayMultiplication[0, 1] = (arrayMatrix1[0, 0] * arrayMatrix2[0, 1]) +
//     (arrayMatrix1[0, 1] * arrayMatrix2[1, 1]);

//     arrayMultiplication[0, 0] = (arrayMatrix1[0, 0] * arrayMatrix2[0, 0]) +
//     (arrayMatrix1[0, 1] * arrayMatrix2[1, 0]);

//     arrayMultiplication[1, 0] = (arrayMatrix1[1, 0] * arrayMatrix2[0, 0]) +
//     (arrayMatrix1[1, 1] * arrayMatrix2[1, 0]);

//     arrayMultiplication[1, 1] = (arrayMatrix1[1, 0] * arrayMatrix2[0, 1]) +
//     (arrayMatrix1[1, 1] * arrayMatrix2[1, 1]);


//     return arrayMultiplication;
// }




// Console.Write("Введите количество строк массива: ");
// int rows1 = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns1 = int.Parse(Console.ReadLine());

// Console.Write("Введите количество строк массива: ");
// int rows2 = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns2 = int.Parse(Console.ReadLine());



// int[,] arrayMatrix1 = GetArrayMatrix1(rows1, columns1, 0, 10);
// int[,] arrayMatrix2 = GetArrayMatrix2(rows2, columns2, 0, 10);
// PrintArrayMatrix1(arrayMatrix1);
// Console.WriteLine();
// PrintArrayMatrix2(arrayMatrix2);
// Console.WriteLine();
// int[,] arrayMultiplicationOfTwoMatrices = GetArraysMultiplication(arrayMatrix1, arrayMatrix2, rows1, rows2, columns1, columns2);
// PrintArrayMultiplication(arrayMultiplicationOfTwoMatrices);


// int[,] GetArrayMatrix1(int m, int n, int minValue, int maxValue) 
// {
//     int[,] arr1 = new int[m, n];
//     for (int i = 0; i < m; i++ ) 
//     {
//         for (int j = 0; j < n; j++) 
//         {
//             arr1[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return arr1;
// }

// void PrintArrayMatrix1(int[,] inArray) 
// {
//     for (int i = 0; i < inArray.GetLength(0); i++ ) 
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++) 
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }        


// int[,] GetArrayMatrix2(int m, int n, int minValue, int maxValue) 
// {
//     int[,] arr2 = new int[m, n];
//     for (int i = 0; i < m; i++ ) 
//     {
//         for (int j = 0; j < n; j++) 
//         {
//             arr2[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return arr2;
// }

// void PrintArrayMatrix2(int[,] inArray) 
// {
//     for (int i = 0; i < inArray.GetLength(0); i++ ) 
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++) 
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] GetArraysMultiplication(int[,] arrayMatrix1, int[,] arrayMatrix2, int rows1, int rows2, int columns1, int columns2) 
// {
//     int[,] arrayMultiplication = new int[rows1, columns2];

//     arrayMultiplication[0, 1] = (arrayMatrix1[0, 0] * arrayMatrix2[0, 1]) +
//     (arrayMatrix1[0, 1] * arrayMatrix2[1, 1]);

//     arrayMultiplication[0, 0] = (arrayMatrix1[0, 0] * arrayMatrix2[0, 0]) +
//     (arrayMatrix1[0, 1] * arrayMatrix2[1, 0]);

//     arrayMultiplication[1, 0] = (arrayMatrix1[1, 0] * arrayMatrix2[0, 0]) +
//     (arrayMatrix1[1, 1] * arrayMatrix2[1, 0]);

//     arrayMultiplication[1, 1] = (arrayMatrix1[1, 0] * arrayMatrix2[0, 1]) +
//     (arrayMatrix1[1, 1] * arrayMatrix2[1, 1]);


//     return arrayMultiplication;
// }

// void PrintArrayMultiplication(int[,] inArray) 
// {
//     for (int i = 0; i < inArray.GetLength(0); i++ ) 
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++) 
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
