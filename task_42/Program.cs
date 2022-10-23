// Напишите программу, которая будет преобразовывать десятичное чмсло 
// в двоичное.
// 45 -> 101101, 3 -> 11, 2 -> 10


// Console.WriteLine("Введите положительное целое число: ");
// int num = int.Parse(Console.ReadLine());

// while (num > 0)
// {
//     int binaryNumber = num % 2;
//     num = num / 2;
//     Console.Write(binaryNumber + " ");
// }




Console.WriteLine("Введите положительное целое число: ");
int num = int.Parse(Console.ReadLine());

var res = ArrayBinNums(num);
PrintArray(res);

int[] ArrayBinNums(int key)
{
    int[] res = new int[32];
    int j = 31;
    while (key > 0)
    {
        res[j] = key % 2;
        key = key / 2;
        j -= 1;
    }
    return res;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + "");
    }
}




