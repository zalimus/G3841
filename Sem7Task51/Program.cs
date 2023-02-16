// Задача №51
// Задайте двумерный массив. Найдите сумму 
// элементов, находящихся на главной диагонали (с 
// индексами (0,0); (1;1) и т.д.
// Например:
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Сумма элементов главной диагонали: 1+9+2 = 12


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

// Метод для нахождения суммы чисел по диагонали матрицы
int DiagSum(int[,] arr)
{
    int res = 0;
    int min = arr.GetLength(0)<arr.GetLength(1) ? arr.GetLength(0):arr.GetLength(1);
    for (int i = 0; i < min; i++)
    {
        res = res + arr[i,i];
    }
    return res;
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
DiagSum(matrix);
Console.WriteLine("Сумма чисел по диагонали матрицы: " + DiagSum(matrix));
