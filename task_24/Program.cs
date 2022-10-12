// Напишите программу, которая принимает на вход число (А) и выдает
// сумму чисел от 1 до А.
// 7 - 28, 4- 10, 8 - 36

// Console. Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// int sum = 0;
// for (int i = 1; i <= number; i++)
// {
//     sum = sum + i;
// }
// Console.WriteLine(sum);



Console. Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма цифр = {GetSumNums(num1)}");
// int num2 = int.Parse(Console.ReadLine());
//   или    int result = GetSumNums(num2);
// Console.WriteLine($"Сумма цифр = {result}");


int GetSumNums(int number) 
{
    int sum = 0;
    while (number > 0)
    {
        sum += number;
        number--;
    }
    return sum;
}