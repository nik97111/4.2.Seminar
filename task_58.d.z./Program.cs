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
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());



int[,] array = GetArray(rows, columns, 0, 10);
PrintArrayMatrix1(array);
PrintArrayMatrix2(array);
// PrintArrayEl(array);
// Console.WriteLine();
// PrintArray(array);

int[,] GetArrayMatrix1(int m, int n, int minValue, int maxValue) 
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


void PrintArrayMatrix1(int[,] inArray) 
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


int[,] GetArrayMatrix2(int m, int n, int minValue, int maxValue) 
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

void PrintArrayMatrix2(int[,] inArray) 
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

// void PrintArrayEL(int[,] inArray) 
// {
//     var sumRow = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++ ) 
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++) 
//         {
//             sumRow += inArray[0, n-1];
//             Console.Write(sumRow);
//         }
//         Console.WriteLine();
//     }
// }


//var arrayMatrix1 = (1...2).map { _ in
//    var arr = Array(repeating: 0, count: 2)
//    for i in 0..<arr.count {
//        arr[i] = Int.random(in: 3...10)
//    }
//    return arr
//}

//print(arrayMatrix1)
////for row1 in arrayMatrix2 {
////    print(row1)
//
//var arrayMatrix2 = (1...2).map { _ in
//    var arr = Array(repeating: 0, count: 2)
//    for i in 0..<arr.count {
//        arr[i] = Int.random(in: 3...9)
//    }
//    return arr
//}
//print(arrayMatrix2)
////for row2 in arrayMatrix2 {
////    print(row2)
//
//var arrayMultiplication = (0...1).map{ _ in [Int](repeating: 0, count: 2)}
//print(arrayMultiplication)
//
//arrayMultiplication[0][1] = (arrayMatrix1[0][0] * arrayMatrix2[0][1]) +
//(arrayMatrix1[0][1] * arrayMatrix2[1][1])
//
//arrayMultiplication[0][0] = (arrayMatrix1[0][0] * arrayMatrix2[0][0]) +
//(arrayMatrix1[0][1] * arrayMatrix2[1][0])
//
//arrayMultiplication[1][0] = (arrayMatrix1[1][0] * arrayMatrix2[0][0]) +
//(arrayMatrix1[1][1] * arrayMatrix2[1][0])
//
//arrayMultiplication[1][1] = (arrayMatrix1[1][0] * arrayMatrix2[0][1]) +
//(arrayMatrix1[1][1] * arrayMatrix2[1][1])
//
//for row3 in arrayMultiplication {
//    print(row3)
//}
