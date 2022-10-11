// Напишите программу, которая принимает на вход число (N) и выдает 
// таблицу кубов чисел от 1 до (N).
// 3 - 1, 8, 27
// 5 - 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    Console.WriteLine(i * i * i);
}