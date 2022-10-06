// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.Write("Введите число не менее трехзначного: ");
int number = int.Parse(Console.ReadLine());

if (number < 99)
{
Console.Write("Третьей цифры нет. Введите число не менее трехзначного: ");
} else 
{
Console.WriteLine(number>99 ? number.ToString()[2] : '-');
Console.ReadKey(true);
}




