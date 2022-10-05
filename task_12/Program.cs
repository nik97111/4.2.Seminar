// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно 

Console.Write("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());

int remainder = numberTwo % 2;
//Console.WriteLine(a);

if ((numberTwo % 2) == 0) {
    Console.WriteLine($"Второе число -> {numberTwo} является кратным");
} else {
    Console.WriteLine($"Второе число -> {numberTwo} не является кратным, остаток от деления -> {remainder}");
}



