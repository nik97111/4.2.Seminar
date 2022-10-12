// Напишите программу, которая принимает на вход число и выдает количество 
// цифр в числе.
// 456 -> 3, 78 -> 2, 89126 -> 5

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int count = 0;
if (count < num)
{
    count = num % 10;
}
Console.WriteLine(count);