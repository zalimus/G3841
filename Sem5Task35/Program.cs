﻿// Задача №35
// Задайте одномерный массив из 123 случайных 
// чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Например:
// Пример для массива из 5, а не 123 элементов. В 
// своем решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1 
// [1, 2, 3, 6, 2] -> 0 
// [10, 11, 12, 13, 14] -> 5


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Выводим результат пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

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

int CountElem(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(Test(arr[i]))
        {
            res++;
        }
    }
    return res;
}

bool Test(int n)
{
    return(n>10&&n<100);
}

int[] testArr = Gen1DArr(123,0,1000);
Print1DArr(testArr);
int count = CountElem(testArr);
PrintData("Количество элементов в отрезке [10, 99]: " + count);