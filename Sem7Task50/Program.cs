// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру


// Метод читает данные от пользователя
int InputNum(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод для заполнения двумерного массива
int [,] Gen2DArr(int n, int m)
{
    int [,] arr = new int [n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = new Random().Next(0, 101);
        }
    }
    return arr;
}

// Метод находит элемент в двумерном массиве
void SerchElem(int[,] arr, int elem)
{
    bool elemFind = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (elem == arr[i, j])
            {
                Console.WriteLine(elem + " - элемент найден, позиция:  " + i + ", " + j);
                elemFind = true;
            }
        }
    }
    if (elemFind == false)
    {
        Console.WriteLine(elem + " - элемент не найден");
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
int elem = InputNum("Введите элемент: ");
int[,] matrix = Gen2DArr(n, m);
Print2DArr(matrix);
SerchElem(matrix, elem);
