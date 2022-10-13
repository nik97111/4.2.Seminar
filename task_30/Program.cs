// Напишите программу, которая выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1, 0, 1, 1, 0, 1, 0, 0]


// int[] cars = new int[8];
// Random random = new Random();
// for (int i = 0; i < 8; i++) {
//     cars[i] = random.Next(2);
//     Console.Write(cars[i] + " ");
// }


// int[] arrayRandom = new int[8];
// for (int i = 0; i < arrayRandom.Length; i++)
// {
//     arrayRandom[i] = new Random().Next(2);
//     Console.Write(arrayRandom[i] + " ");
// }


int[] arrayRandom = new int[8];
ArrayRandom(arrayRandom);

int[] ArrayRandom(int[] arrayRandom) 
{
    for (int i = 0; i < arrayRandom.Length; i++)
    {
        arrayRandom[i] = new Random().Next(2);
        Console.Write(arrayRandom[i] + " ");
    }
    return arrayRandom;
}








