// Напишите программу, которая принимает на вход число (N) и выдает таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 6, 25
// 2 -> 1, 4

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());


for (int i = 1; i <= number; i++)
{
    Console.WriteLine(i * i);
}