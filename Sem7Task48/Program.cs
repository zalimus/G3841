// Задача №48
// Задайте двумерный массив размера m на n, каждый 
// элемент в массиве находится по формуле: Aₘₙ = 
// m+n. Выведите полученный массив на экран.
// Пример:
// m = 3, n = 4. 
// 0 1 2 3
// 1 2 3 4 
// 2 3 4 5


int InputNum(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод для заполнения двумерного массива
int[,] Gen2DArr(int n, int m)
{
    int[,] arr = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = i+j;
        }
    }
    return arr;
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

int n = InputNum("Количество строк матрицы: ");
int m = InputNum("Количество столбцов матрицы: ");
int[,] matrix = Gen2DArr(n, m);
Print2DArr(matrix);
