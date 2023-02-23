// Задача №53 
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю 
// строку массива.


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
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

// Метод меняет местами первую и последнюю строку массива
void SwapRaw2DArray(int[,] matrix)
{
    int k = 0;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        // Значение из первой строки передаем в переменную
        k = matrix[0, i];
        // Значение из последней строки передаем в первую строку
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        // Значение из переменной передаем в последнюю строку
        matrix[matrix.GetLength(0) - 1, i] = k;
    }
}

int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество столбцов матрицы: ");
int[,] matrix = Gen2DArr(m, n, 0, 100);
Print2DArr(matrix);
SwapRaw2DArray(matrix);
Console.WriteLine();
Print2DArr(matrix);
