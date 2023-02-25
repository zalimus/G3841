// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        return null;
    }
    
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;

            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return matrixC;
}

int n1 = ReadData("Количество строк матрицы A: ");
int m1 = ReadData("Количество столбцов матрицы A: ");
int n2 = ReadData("Количество строк матрицы B: ");
int m2 = ReadData("Количество столбцов матрицы B: ");

int[,] matrixA = Gen2DArr(n1, m1, 0, 5);
int[,] matrixB = Gen2DArr(n2, m2, 0, 5);
Print2DArr(matrixA);
Console.WriteLine();
Print2DArr(matrixB);
Console.WriteLine();

int[,] matrixMult = MatrixMultiplication(matrixA, matrixB);
if (matrixMult != null)
{
    Print2DArr(matrixMult);
}
