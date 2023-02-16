// Задача №49
// Задайте двумерный массив. Найдите элементы, у 
// которых оба индекса чётные, и замените эти 
// элементы на их квадраты.
// Например:
// Например, изначально массив выглядел вот так: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Новый массив будет выглядеть вот так: 
// 1 4 7 2 
// 5 81 2 9 
// 8 4 2 4


// Метод читает данные от пользователя
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
            arr[i, j] = i + j;
        }
    }
    return arr;
}

// Метод для замены чисел их квадратом
void Update2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < arr.GetLength(1); j = j + 2)
        {
            arr[i, j] = (int)Math.Pow(arr[i, j], 2);
        }
    }
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
int[,] matrix = Gen2DArr(n,m);
Print2DArr(matrix);
Update2DArr(matrix);
Console.WriteLine();
Print2DArr(matrix);
