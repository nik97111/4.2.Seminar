﻿// Напишите программу, которая принимает на вход число N и выдает 
// произведение чисел от 1 до N.
// 4 -> 24, 5 -> 120

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

//int sum = 1;
// for (int i = 1; i <= num; i++)
// {
//     sum = sum * i;
// }
// Console.WriteLine(sum);


int sum = 1;
int i = 0;
while (i < num)
{
    i++;
    sum = sum * i;
}
Console.WriteLine(sum);



