// Найдите произведение пар чисел в одномерном массиве. Парой считаем 
// первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1, 2, 3, 4, 5] -> 5 8 3
// [6, 7, 3, 6] -> 36 21



// int[] arr = {4, 6, 3, 7};
// int sumFirstLast = 0;
// int sumSecondPenultimate = 0;

// sumFirstLast = arr.First() * arr.Last();
// sumSecondPenultimate = ((arr.First() - 1) * (arr.Last() - 1));
// int[] arrRes = new int[]{sumFirstLast, sumSecondPenultimate};
// for (int i = 0; i < arrRes.Length; i++)
// {
//     Console.WriteLine();
//     Console.Write($"{arr[i]} -> {arrRes[i]} ");
// }



int[] array = new int[] { 4, 6, 5, 19, 6, 3, 7 };

var i = 0;
var j = array.Length - 1;
while (i <= j) {
    if (i != j) {
        Console.Write(array[i] * array[j] + " ");
    } else {
        Console.WriteLine(array[i]);
    }

    i += 1;
    j -= 1;
}



