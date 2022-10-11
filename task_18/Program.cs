// Напишите программу, которая по заданному номеру четверти показывает 
// диапазон возможных координат точек в этой четверти (x и y).


Console.Write("Введите номер четверти: ");
int quatre = int.Parse(Console.ReadLine());

// if (quatre == 1)
// {
//     Console.WriteLine("Диапазон возможных координат: x > 0 и y > 0 ");
// }
// if (quatre == 2)
// {
//     Console.WriteLine("Диапазон возможных координат: x < 0 и y > 0 ");
// }
// if (quatre == 3)
// {
//     Console.WriteLine("Диапазон возможных координат: x < 0 и y < 0 ");
// }
// if (quatre == 4)
// {
//     Console.WriteLine("Диапазон возможных координат: x > 0 и y < 0 ");
// } else 
// {
//     Console.WriteLine("Введите корректный номер четверти");
// } 

if (quatre > 0 && quatre < 5)
{
    if (quatre == 1)
    Console.WriteLine("Диапазон возможных координат: x > 0 и y > 0 ");
    else if (quatre == 2)
    Console.WriteLine("Диапазон возможных координат: x < 0 и y > 0 ");
    else if (quatre == 3)
    Console.WriteLine("Диапазон возможных координат: x < 0 и y < 0 ");
    else if (quatre == 4)
    Console.WriteLine("Диапазон возможных координат: x > 0 и y < 0 ");
} else
{
    Console.WriteLine("Введите корректный номер четверти: от 1 до 4");
}
 