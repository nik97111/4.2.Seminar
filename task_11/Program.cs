// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру 
// этого числа.
// 456 -> 46, 782 -> 12, 918 -> 98

int numberRandom  = new Random().Next(100, 1000);
Console.WriteLine(numberRandom + " - рандомное число");

int digitOne = numberRandom / 100;
int digitTwo = numberRandom % 10;
Console.WriteLine($"Трехзначное число {numberRandom} превратилось в двухзначное {digitOne}{digitTwo}");

