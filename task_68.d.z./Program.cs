// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

int FuncAkkerman(int m, int n) 
{
    if (m == 0) 
    {
        return n + 1;
    } 
    else if (n == 0 && m > 0) 
    {
        return FuncAkkerman(m - 1, 1);
    } 
    else 
    {
        return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
    }
}
Console.WriteLine(FuncAkkerman(m, n));




// int recursion(int m, int n) 
// {
//     if (m == 0) 
//     {
//         return n + 1;
//     } 
//     else if (n == 0 && m > 0) 
//     {
//         return recursion(m - 1, 1);
//     } 
//     else 
//     {
//         return recursion(m - 1, recursion(m, n - 1));
//     }
// }
// Console.WriteLine(recursion(m, n));



// int recursion(int m, int n) {
//         // Базовый случай
//         if (m == 0) {
//             return n + 1;
//         } // Шаг рекурсии / рекурсивное условие
//         else if (n == 0 && m > 0) {
//             return recursion(m - 1, 1);
//         } // Шаг рекурсии / рекурсивное условие
//         else {
//             return recursion(m - 1, recursion(m, n - 1));
//         }
//     }
//     public static void main(String[] args) {
//         System.out.println(recursion(3, 2)); // вызов рекурсивной функции
//    }