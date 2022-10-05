// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа
// 78 -> 8
// 12 -> 2
// 85 -> 8


int numberRandom = new Random().Next(10, 100);
Console.WriteLine(numberRandom + " - рандомное число");

int numberConsole = numberRandom;
//Console.WriteLine(numberConsole);

int digitOne = numberConsole / 10;
Console.WriteLine(digitOne + " - первая цифра числа");

int digitTwo = (numberConsole % 10);
Console.WriteLine(digitTwo + " - вторая цифра числа"); 


if (digitOne > digitTwo) {
    Console.WriteLine("Первая цифра числа больше второй");
} else if (digitTwo > digitOne) {
    Console.WriteLine("Вторая цифра числа больше первой");
} else {
    Console.WriteLine("Цифры числа равны");
}


// int num = new Random().Next(10, 100);
// int a1 = num / 10;
// int a2 = num % 10;
// int max = a1;
// Console.WriteLine($"{a1}, {a2}");

// if (max < a2)
// {
//     max = a2;
// }
// Console.WriteLine($"Максимальная цифра в числе {num} -> {max}");