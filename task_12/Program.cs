// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно 

Console.Write("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());

int remainder = numberOne % numberTwo;

if ((numberOne % numberTwo) == 0) {
    Console.WriteLine($"Второе число -> {numberTwo} является кратным первому -> {numberOne}");
} else {
    Console.WriteLine($"Второе число -> {numberTwo} не является кратным первому, остаток от деления -> {remainder}");
}



