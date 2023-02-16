// Задача №46
// Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// Например: 
// m = 3, n = 4. 
// -1 4 8 19 
// 5 -2 33 -2 
// -77 3 8 1


// 1) Получение данных от пользователя

// Console.WriteLine("Количество строк матрицы");
// int n = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Количество столбцов матрицы");
// int m = int.Parse(Console.ReadLine()?? "0");

int n = InputNum("Количество строк матрицы: ");
int m = InputNum("Количество столбцов матрицы: ");


// 2) Генерация двумерного массива

// System.Random numberSyntezator = new System.Random();
// int i = 0; int j = 0;
// int[,] outArray = new int[n, m];
// while (i < n)
// {
//     j = 0;
//     while (j < m)
//     {
//         outArray[i, j] = numberSyntezator.Next(0, 101);
//         j++;
//     }
//     i++;
// }

int[,] matrix = FillTwoDimArray(n, m);

// 3) Печатаем двумерный массив

// i = 0; j = 0;
// while (i < n)
// {
//     j = 0;
//     while (j < m)
//     {
//         Console.Write(outArray[i, j] + " ");
//         j++;
//     }
//     i++;
//     Console.WriteLine();
// }

PrintTwoimlArray(matrix);

// Метод читает данные от пользователя
int InputNum(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод для заполнения двумерного массива
int[,] FillTwoDimArray(int n, int m)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[n, m];
    while (i < n)
    {
        j = 0;
        while (j < m)
        {
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;
    }
    return outArray;
}

// Метод для печати двумерного массива
void PrintTwoimlArray(int[,] inputArray)
{
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}