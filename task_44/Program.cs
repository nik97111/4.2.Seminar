// Не используя рекурсию выведите первые N чисел Фибоначчи. Первые два
// числа Фибоначчи: 0 и 1
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



int GetNumber()
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = GetNumber();
int[] array = new int[number];
array[0] = 0;
array[1] = 1;
for (int i = 2; i < number; i++) 
{
    array[i] = array[i-1] + array[i-2];
}
for (int i = 0; i < number; i++) 
{
    Console.Write(array[i] + " ");
}