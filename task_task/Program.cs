// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на 
// старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ['1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


string[] array = {"Варан", "Ёж", "Сова", "Лещ", "Бегемот", "Як", "Слон"};

int arrayFirstCount = GetArrayCount(array);
string[] arraySecond = GetArrayNew(array, arrayFirstCount);
PrintArray(arraySecond);

int GetArrayCount(string[] array)
{
    var count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] GetArrayNew(string[] array, int arrayFirstCount)
{
    string[] arrayNew = new string[arrayFirstCount];
    var countEl = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            arrayNew[countEl++] = array[i];
        } 
    }
    return arrayNew;
}

void PrintArray(string[] arrayNew)
{
    for (int i = 0; i < arrayNew.Length; i++)
    {
        Console.Write(arrayNew[i] + " ");
    }
}



// var count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i].Length <= 3)
//     {
//         count++;
//     }
// }

// string[] arrayNew = new string[count];
// var countEl = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i].Length <= 3)
//     {
//         arrayNew[countEl++] = array[i];
//     }
// }

// for (int i = 0; i < arrayNew.Length; i++)
// {
//     Console.Write(arrayNew[i] + " ");
// }




// using System.Collections;

// string[] arr = {"Варан", "Ёж", "Сова", "Лещ", "Бегемот", "Як", "Слон"};
// string[] array = GetArray(arr);

// PrintArray(array);
// Console.WriteLine();

// string[] GetArray(string[] arr)
// {
//     ArrayList arrayNew = new ArrayList(); 
//     foreach (string i in arr)
//     {
//         if (i.Length <= 3)
//         {
//             arrayNew.Add(i);
//         }
//     }
//     return (string[])arrayNew.ToArray(typeof(string));
// }

// void PrintArray(string[] arr)
// {
//     foreach (string i in arr)
//     {
//             Console.Write(i + " ");
//     }
// }




// using System.Collections;

// string[] array = {"Варан", "Ёж", "Сова", "Лещ", "Бегемот", "Як", "Слон"};

// ArrayList arrayNew = new ArrayList(); 

// foreach (string i in array)
// {
//     if (i.Length <= 3)
//     {
//         arrayNew.Add(i);
//     }
// }

// foreach (string i in arrayNew)
// {
//     Console.Write(i + " ");
// }




// void ArraySecond(string[] array, string[] arrayNew)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//     if(array[i].Length <= 3)
//         {
//         arrayNew[count] = array[i];
//         count++;
//         }
//     }
// }

// void PrintArray(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// ArraySecond(array, arrayNew);
// PrintArray(arrayNew);
