// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19 
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю



// Генерация массива чисел
int[] Gen1DArr(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

// Печать массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}


// Выводим результат пользователю
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

// Подсчет четных чисел
int SumPos(int[] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i=i+2)
    {
        res+=arr[i];
    }
    return res;
}

int[] testArr = Gen1DArr(5, 0, 9);
Print1DArr(testArr);
int sum = SumPos(testArr);
PrintData("Сумма элементов на нечётных позициях: ", sum);