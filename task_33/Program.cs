// Задайте массив. Напишите программу, которая определяет, присутсвует 
// ли заданное число в массиве.
// 4;  массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да



int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 9);
    Console.Write($"{array[i]} ");
}
    Console.WriteLine();
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    
    bool found = false;
for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i]) {
            found = true;
            break;
        }
    }

    if (found) {
        Console.WriteLine("Это число есть в массиве");
    } else {
        Console.WriteLine("Этого числа нет в массиве");
    }