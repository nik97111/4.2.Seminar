// Напишите программу, которая принимает на вход цифру, обозначающую день недели и 
// проверяет, является ли этот день выходным.
// 6 -> да, 7 -> да, 1 -> нет


// 1-й способ

// Console.Write("Введите цифру от 1 до 7: ");
// int day = int.Parse(Console.ReadLine());

// if (day == 1) {
//     Console.WriteLine("Рабочий день");
// } else if (day == 2) {
//     Console.WriteLine("Рабочий день");
// } else if (day == 3) {
//     Console.WriteLine("Рабочий день");
// } else if (day ==4) {
//     Console.WriteLine("Рабочий день");
// } else if (day == 5) {
//     Console.WriteLine("Рабочий день");
// } else if (day == 6) {
//     Console.WriteLine("Выходной день");
// } else if (day == 7) {
//     Console.WriteLine("Выходной день");
// } else {
//     Console.WriteLine("Введите цифру от 1 до 7");
// }

// Короткая запись 1-го способа

Console.Write("Введите цифру от 1 до 7: ");
int day = int.Parse(Console.ReadLine());

if (day <= 5) {
    Console.WriteLine("Рабочий день");
} else if ((day == 6) || (day == 7)) {
    Console.WriteLine("Выходной день");
} else {
        Console.WriteLine("Введите цифру от 1 до 7");
}


// string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", 
// "Воскресенье" };
// Console.WriteLine(daysOfWeek);