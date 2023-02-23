// Задача №55 
// Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, 
// если это невозможно, программа должна вывести 
// сообщение для пользователя.


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

// Метод меняет местами первую горизонтальную и первую вертикальную строки массива
void TransArray(int[,] matrix)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            k = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = k;
        }
    }
}

bool TestArray(int[,] arr)
{
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        return true;
    }
    else
    {
        Console.WriteLine("Матрицу перевернуть нельзя!");
        return false;
    }
}

int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество столбцов матрицы: ");
int[,] matrix = Gen2DArr(m, n, 0, 100);
Print2DArr(matrix);
Console.WriteLine();

if (TestArray(matrix))
{
    TransArray(matrix);
    Print2DArr(matrix);
}