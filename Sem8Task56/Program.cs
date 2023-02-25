// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод для заполнения двумерного массива
int[,] Gen2DArr(int raw, int col, int min, int max)
{
    int[,] matrix = new int[raw, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

// Метод для печати двумерного массива
void Print2DArr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

// Сортировки строки двумерного массива
int MinSum2DArr(int[,] arr)
{
    int minSum = int.MaxValue;
    int minRow = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            rowSum += arr[i, j];
        }

        if (rowSum < minSum)
        {
            minSum = rowSum;
            minRow = i + 1;
        }
    }
    return minRow;
}

int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество столбцов матрицы: ");
int[,] matrix = Gen2DArr(m, n, 0, 100);
Print2DArr(matrix);
Console.WriteLine();
int line = MinSum2DArr(matrix);
Console.WriteLine(line + " строка");
