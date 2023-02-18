// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом 
// столбце.
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным 
// цветом.


// Метод читает данные от пользователя
int InputNum(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод для заполнения двумерного массива
int [,] Gen2DArr(int n, int m)
{
    int [,] arr = new int [n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = new Random().Next(0, 100);
        }
    }
    return arr;
}

// Метод находит среднее арифметическое элементов в столбце 
double[] MeanColum (int[,] arr)
{
    double[] means = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            means[i] += arr[j,i];
        }
        means[i] = Math.Round((double)means[i]/arr.GetLength(0), 4);
    }
    
    return means;
}

// Метод для печати двумерного массива
void Print2DArr(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

// Метод для печати одномерного массива
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int n = InputNum("Количество строк матрицы: ");
int m = InputNum("Количество столбцов матрицы: ");
int[,] matrix = Gen2DArr(n, m);
Print2DArr(matrix);
double[] arr = MeanColum(matrix);
Print1DArr(arr);

