// Задайте массив, заполненный случайными положительными трехзначными 
// числами. Напишите программу, которая покажет количество четных чисел 
// в массиве
// [345, 987, 568, 234] -> 2


// int[] arrayRandom = new int[4];
// int countPositiveNumbers = 0;

// for (int i = 0; i < arrayRandom.Length; i++)
// {
//     arrayRandom[i] = new Random().Next(1000);
//     Console.Write($"{arrayRandom[i]} ");
//     if ((arrayRandom[i]) % 2 == 0)
//         countPositiveNumbers += 1;
// }
// Console.WriteLine();
// Console.WriteLine($"Четных чисел в массиве - {countPositiveNumbers}");


int[] arrayRandom = new int[4];
int countPositiveNumbers = 0;
ArrayRandom(arrayRandom);

int[] ArrayRandom(int[] arrayRandom)
{
    for (int i = 0; i < arrayRandom.Length; i++)
    {
        arrayRandom[i] = new Random().Next(1000);
        Console.Write($"{arrayRandom[i]} ");
        if ((arrayRandom[i]) % 2 == 0)
            countPositiveNumbers += 1;
    }
    return arrayRandom;
}
Console.WriteLine();
Console.WriteLine($"Четных чисел в массиве - {countPositiveNumbers}");