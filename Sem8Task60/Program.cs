// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод для заполнения двумерного массива
int[,,] Gen3DArr(int width, int height, int depth, int min, int max)
{
    int[,,] matrix = new int[width, height, depth];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(min, max + 1);
            }
        }

    }
    return matrix;
}

// Метод для печати трехмерного массива
void Print3DArr(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + "(" + i + ", " + j + ", " + k + ")" + "\t");
            }
            Console.WriteLine("");
        }
    }
}

int n = ReadData("Количество ячеек в ширину: ");
int m = ReadData("Количество ячеек в длину: ");
int e = ReadData("Количество ячеек в глубину: ");
int[,,] matrix = Gen3DArr(m, n, e, 10, 100);
Print3DArr(matrix);
Console.WriteLine();