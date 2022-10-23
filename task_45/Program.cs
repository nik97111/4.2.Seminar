// Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.



int[] arrayFirst = {3, 9, 0, 6, 7};
int[] arraySecond = new int[arrayFirst.Length];

for (int i = 0; i < arrayFirst.Length; i++)
{
    arraySecond[i] = arrayFirst[i];
    Console.Write(arraySecond[i] + " ");
}



