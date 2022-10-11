// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет, 23432 -> да, 12821 -> да

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int digitOne = number / 10000;
int digitFive = number % 10;
int digitTwo = (number / 1000) % 10;
int digitFour = (number / 10) % 10;

if ((digitOne == digitFive) && (digitTwo == digitFour))
{
    Console.WriteLine("Это число является палиндромом");
} else 
{
    Console.WriteLine("Это число не является палиндромом");
}
