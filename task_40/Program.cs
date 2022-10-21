// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше
// суммы двух других сторон. 


// Console.WriteLine("Введите первое число: ");
// int numFirst = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int numSecond = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int numThree = int.Parse(Console.ReadLine());


// if ((numFirst < (numSecond + numThree)) && (numSecond < (numFirst + numThree)) 
// && (numThree < (numFirst + numSecond)))
//     Console.WriteLine("Треугольник может существовать");
// else 
//     Console.WriteLine("Треугольник не может существовать");



int numberFirst = GetNumber();
int numberSecond = GetNumber();
int numberThree = GetNumber();
PrintRes(numberFirst, numberSecond, numberThree);

int GetNumber()
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()); 
    return number;
}

void PrintRes(int numFirst, int numSecond, int numThree)
{
    if (numFirst > 0 && numSecond > 0 && numThree > 0)
        if ((numFirst < (numSecond + numThree)) && (numSecond < (numFirst + numThree)) 
        && (numThree < (numFirst + numSecond)))  
            Console.WriteLine("Треугольник может существовать");
        else 
            Console.WriteLine("Треугольник не может существовать");
    else 
        Console.WriteLine("Введите число больше нуля");
    
}
// void PrintRes(int numFirst, int numSecond, int numThree)
// {
//     if (numFirst > 0 && numSecond > 0 && numThree > 0)
//     {
//         if ((numFirst < (numSecond + numThree)) && (numSecond < (numFirst + numThree)) 
//         && (numThree < (numFirst + numSecond)))
//         {   
//             Console.WriteLine("Треугольник может существовать");
//         }
//         else 
//         {
//             Console.WriteLine("Треугольник не может существовать");
//         }
//     }
//     else 
//     {
//         Console.WriteLine("Введите число больше нуля");
//     }
    
// }





