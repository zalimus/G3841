// Задача №31 
// Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных 
// элементов массива.
// Например: 
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма 
// отрицательных равна -20.


int positiveSum = 0;
int negativeSum = 0;

int[] testArr = Gen1DArr(12,-9,9);
NegPosSum(testArr);
Print1DArr(testArr);
PrintData("Сумма положительных чисел: ", positiveSum);
PrintData("Сумма отрицательных чисел: ", negativeSum);

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

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

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void NegPosSum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positiveSum += arr[i];
        }
        else
        {
            negativeSum += arr[i];
        }
    }
}
