// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите 
// разницу между первым и последним элементом. Для задачи со звездочкой 
// использовать заполнение массива целыми числами



// Генерация массива чисел
double[] Gen1DArr(int len, double minValue, double maxValue)
{
    Random rnd = new Random();
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (maxValue - minValue) + minValue;
    }
    return arr;
}

// Печать массива
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}


// Выводим результат пользователю
void PrintData(string res, double value)
{
    Console.WriteLine(res + value);
}

// Подсчет четных чисел
double MinMax(double[] arr)
{
    double max = double.MinValue;
    double min = double.MaxValue;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return max - min;
}

double[] testArr = Gen1DArr(5, 0, 9);
Print1DArr(testArr);
double diff = MinMax(testArr);
PrintData("Разница между максимальным и минимальным элементов массива составляет: ", diff);
