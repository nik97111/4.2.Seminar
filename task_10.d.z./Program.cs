// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает 
// вторую цифру этого числа.
//456 -> 5, 782 -> 8, 918 -> 1 

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int digitFirst = number / 10;
int digitSecond = digitFirst / 10;
int digitThird = digitSecond * 10;
int digitFourth = digitFirst - digitThird;
Console.WriteLine(digitFourth);
