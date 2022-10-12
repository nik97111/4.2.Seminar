// Напишите программу, которая принимает на вход число (А) и выдает
// сумму чисел от 1 до А.
// 7 - 28, 4- 10, 8 - 36

Console. Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= number; i++)
{
    sum = sum + i;
}
Console.WriteLine(sum);