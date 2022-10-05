// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.Write("Введите число не менее двухзначного: ");
int number = int.Parse(Console.ReadLine());

int digitThree = 0;

if ((number >= 100) && (number < 1000)) 
{
    digitThree = number % 10;
    Console.WriteLine(digitThree);
} else 
{
    Console.WriteLine("Третьей цифры нет");
}