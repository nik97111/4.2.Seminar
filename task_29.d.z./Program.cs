// Напишите программу, которая задает массив из 8 элементов и выводит 
// их на экран.

int[] arrayRandom = new int[8];
ArrayInput(arrayRandom);
ArrayOutput(arrayRandom);

void ArrayInput(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2);
    }
}

void ArrayOutput(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


// int[] arrayRandom = new int[8];
// ArrayRandom(arrayRandom);

// int[] ArrayRandom(int[] arrayRandom) 
// {
//     for (int i = 0; i < arrayRandom.Length; i++)
//     {
//         arrayRandom[i] = new Random().Next(2);
//         Console.Write(arrayRandom[i] + " ");
//     }
//     return arrayRandom;
// }