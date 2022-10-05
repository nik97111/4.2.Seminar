// // Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число
// квадратом другого.
// 5, 25 -> да, -4, 16 -> да, 25, 5 -> да, 8, 9 -> нет 

Console.Write("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());

if (((numberOne / numberTwo) == numberTwo) || ((numberTwo / numberOne) == numberOne))
{
    Console.WriteLine("Одно из чисел является квадратом другого");
} else 
{
    Console.WriteLine("Одно из чисел не является квадратом другого");
}