// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива.
// [3, 7, 22, 2, 78] -> 76



// int[] arrayRandom = new int[6];
// int difference = 0;

// for (int i = 0; i < arrayRandom.Length; i++)
// {
//     arrayRandom[i] = new Random().Next(1, 100);
//     Console.Write($"{arrayRandom[i]} ");
// }
//     difference = arrayRandom.Max() - arrayRandom.Min();
//     Console.WriteLine();
//     Console.WriteLine($"Разница = {difference}");


int[] arrayRandom = new int[6];
int difference = 0;
ArrayRandom(arrayRandom);

int[] ArrayRandom(int[] arrayRandom)
{
for (int i = 0; i < arrayRandom.Length; i++)
{
    arrayRandom[i] = new Random().Next(1, 100);
    Console.Write($"{arrayRandom[i]} ");
}
    difference = arrayRandom.Max() - arrayRandom.Min();
    Console.WriteLine();
    Console.WriteLine($"Разница = {difference}");

    return arrayRandom;
}