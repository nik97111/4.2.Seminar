// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Console.Write("Введите количество чисел: ");
// int m = int.Parse(Console.ReadLine());
// int count = 0;

// for (int i = 1; i <= m; i++) {
//     Console.Write("Введите " + i + " число: ");
//     int number = int.Parse(Console.ReadLine());

//     if (number > 0) {
//         count += 1;
//     }
// }

// Console.WriteLine($"Чисел больше 0 = {count}");



int m = GetCountM();
int count = GetNums(m);
RrintCount(count);

int GetCountM()
{
    Console.Write("Введите количество чисел: ");
    int m = int.Parse(Console.ReadLine());
    return m;
}

int GetNums(int m)
{
    int count = 0;

    for (int i = 1; i <= m; i++) 
    {
        Console.Write("Введите " + i + " число: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0) 
        {
            count += 1;
        }
    }

    return count;
}

void RrintCount(int count)
{
    Console.WriteLine($"Чисел больше 0 = {count}");
}