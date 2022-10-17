// Задайте одномерный массив из 123 случайных чисел. Найдите количество
// элементов массива, значения которых лежат в отрезке [10, 99].
// Пример для массива из 5, а не 123 элементов. В саоем решении сделайте 
// так для 123.
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



// int[] array = new int[123];
// int countElArray = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100);
//     Console.Write($"{array[i]} ");
//     if (array[i] >= 10 && array[i] <= 99)
//     {
//         countElArray += 1;
//     }  
// }
// Console.WriteLine();
// Console.WriteLine(countElArray);



int[] array = new int[123];
int countElArray = 0;
Array(array);

int[] Array(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
        Console.Write($"{array[i]} ");

        if (array[i] >= 10 && array[i] <= 99)
        {
            countElArray += 1;
        }
    }
    return array;
}
Console.WriteLine();
Console.WriteLine(countElArray);