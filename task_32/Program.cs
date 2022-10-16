// Напишите программу замены элементов массива: положительные элементы 
// замените на соответствующие отрицательные и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// int[] array = new int[4];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 9);
//     Console.Write($"{array[i]} ");
//     array[i] = -array[i];
// }
// Console.WriteLine();
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"{array[i]} ");
// }



int[] array = new int[4];
Array(array);

int[] Array(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 9);
        Console.Write($"{array[i]} ");
        array[i] = -array[i];
    }
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    return array;
}


// int[] array = new int[4];

// foreach(int el in array)
// {   
//     array[el] = new Random().Next(-9, 9);

//     if (el > 0)
//         el =  -el;
//     else
//         el = el;
// }
// Console.WriteLine(array[el]);