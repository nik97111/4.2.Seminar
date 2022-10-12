// Напишите программу, которая принимает на вход число и выдает количество 
// цифр в числе.
// 456 -> 3, 78 -> 2, 89126 -> 5




// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// int count = 0;
// while (number >= 1)
// {
//     number = number / 10;
//     count++;
// }
// Console.WriteLine(count);


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе - {CountDigits(num)}");

int CountDigits(int number) 
{
int count = 0;
while (number >= 1)
{
    number = number / 10;
    count++;
}
    return count;
}

