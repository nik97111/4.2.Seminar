// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int[] arrayRandom = new int[4];
// int sumElNegativeIndex = 0;

// for (int i = 0; i < arrayRandom.Length; i++)
// {
//     arrayRandom[i] = new Random().Next(-100, 100);
//     Console.Write($"{arrayRandom[i]} ");

//     if ((i % 2) != 0)
//     sumElNegativeIndex += arrayRandom[i]; 
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма элементов массива, стоящих на нечетных индексах = {sumElNegativeIndex}");



int[] arrayRandom = new int[4];
int sumElNegativeIndex = 0;
ArrayRandom(arrayRandom);

int[] ArrayRandom(int[] arrayRandom)
{
    for (int i = 0; i < arrayRandom.Length; i++)
    {
        arrayRandom[i] = new Random().Next(-100, 100);
        Console.Write($"{arrayRandom[i]} ");

        if ((i % 2) != 0)
        sumElNegativeIndex += arrayRandom[i]; 
    }
    return arrayRandom;
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных индексах = {sumElNegativeIndex}");

