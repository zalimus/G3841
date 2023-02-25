// Задача 54: Задайте двумерный массив. Напишите программу, которая  
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

// Сортировки одномерного массива
int[] Sort1DArr(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] < arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    
    return arr;
}

// Сортировка строки двумерного массива
void Sort2DArr(int[,] arr)
{
    int[] bufA = new int[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            bufA[j] = arr[i, j];
        }

        bufA = Sort1DArr(bufA);

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = bufA[j];
        }
    }
}

int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество столбцов матрицы: ");
int[,] matrix = Gen2DArr(m, n, 0, 100);
Print2DArr(matrix);
Console.WriteLine();
Sort2DArr(matrix);
Print2DArr(matrix);
