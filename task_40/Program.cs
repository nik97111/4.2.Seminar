// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше
// суммы двух других сторон. 


Console.WriteLine("Введите первое число: ");
int numFirst = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numSecond = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numThree = int.Parse(Console.ReadLine());


if ((numFirst < (numSecond + numThree)) && (numSecond < (numFirst + numThree)) 
&& (numThree < (numFirst + numSecond)))
    Console.WriteLine("Треугольник может существовать");
else 
    Console.WriteLine("Треугольник не может существовать");






