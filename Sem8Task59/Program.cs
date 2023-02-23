// Задача №59
// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и 
// столбец, на пересечении которых расположен 
// наименьший элемент массива.


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

// Метод находит наименьший элемент массива 
(int x, int y) SerchMinElem(int[,] matrix)
{
    int raw = 0;
    int col = 0;
    int minElem = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (minElem > matrix[i, j])
            {
                raw = i;
                col = j;
                minElem = matrix[i, j];
            }
        }
    }
    return (raw, col);
}

// Метод удаляет строку и столбец, на пересечении которых расположен наименьший элемент массива
int[,] Update2DArr(int[,] matrix, int x, int y)
{
    int[,] resArr = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    int k = 0;
    int m = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        m = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != x && j != y)
            {
                resArr[k, m] = matrix[i, j];
            }
            if (j != y)
            {
                m++;
            }
        }
        if (i != x)
        {
            k++;
        }
    }
    return resArr;
}


int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество столбцов матрицы: ");
int[,] matrix = Gen2DArr(m, n, 0, 100);
Print2DArr(matrix);
Console.WriteLine();

(int x, int y) minElem = SerchMinElem(matrix);

int[,] newMatrix = Update2DArr(matrix, minElem.x, minElem.y);
Print2DArr(newMatrix);
