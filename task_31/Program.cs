// Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных 
// элементов массива. 
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма 
// положительных чисел равна 29, сумма отрицательных -20.



// int[] arrayRandom = new int[12];

// int sumPositiveNumbers = 0;
// int sumNegativeNumbers = 0;

// for (int i = 0; i < arrayRandom.Length; i++)
// {
//     arrayRandom[i] = new Random().Next(-9, 9);

//     if (arrayRandom[i] > 0)
//     {
//         sumPositiveNumbers += arrayRandom[i];
//     } else if (arrayRandom[i] < 0)
//     {
//         sumNegativeNumbers += arrayRandom[i];
//     }
// }
// Console.WriteLine($"Сумма положительных чисел = {sumPositiveNumbers}, сумма отрицательных чисел = {sumNegativeNumbers}");




// int[] arrayRandom = new int[12];
// Random r = new Random();

// int sumPositiveNumbers = 0;
// int sumNegativeNumbers = 0;

// for (int i = 0; i < arrayRandom.Length; i++)
// {
//     arrayRandom[i] = r.Next(-9, 9);

//     if (arrayRandom[i] > 0)
//     {
//         sumPositiveNumbers += arrayRandom[i];
//     } else if (arrayRandom[i] < 0)
//     {
//         sumNegativeNumbers += arrayRandom[i];
//     }
// }
// Console.WriteLine($"Сумма положительных чисел = {sumPositiveNumbers}, сумма отрицательных чисел = {sumNegativeNumbers}");



int[] arrayRandom = new int[12];
ArrayRandom(arrayRandom);

int[] ArrayRandom(int[] arrayRandom) 
{
     int sumPositiveNumbers = 0;
     int sumNegativeNumbers = 0;

     for (int i = 0; i < arrayRandom.Length; i++)
     {
         arrayRandom[i] = new Random().Next(-9, 9);

         if (arrayRandom[i] > 0)
             sumPositiveNumbers += arrayRandom[i];
           else if (arrayRandom[i] < 0)
             sumNegativeNumbers += arrayRandom[i];
     }
     Console.WriteLine($"Сумма положительных чисел = {sumPositiveNumbers}, сумма отрицательных чисел = {sumNegativeNumbers}");
     return arrayRandom;
 }


// Решение из лекции
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//         Console.Write($"{res[i]} ");
//     }
//     return res;
// }
// int[] array = GetArray(12, -9, 9);
// int positiveSum = 0;
// int negativeSum = 0;
// foreach(int el in array)
// {
//     if (el > 0)
//         positiveSum += el;
//     else
//         negativeSum += el;
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма положительных чисел = {positiveSum}, сумма отрицательных чисел = {negativeSum}");