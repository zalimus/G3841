// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4. 
// 0,5 7 -2 -0,2 
// 1 -3,3 8 -9,9 
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)


// Метод читает данные от пользователя
int InputNum(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод для заполнения двумерного массива
double [,] Gen2DArr(int n, int m)
{
    double[,] arr = new double[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = new Random().Next(0, 101) + new Random().NextDouble();
        }
    }
    return arr;
}

// Метод для печати двумерного массива
void Print2DArr(double[,] inputArray)
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
double[,] matrix = Gen2DArr(n,m);
Print2DArr(matrix);