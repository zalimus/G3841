// Задача №33 
// Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// Например:
// 4; массив [6, 7, 19, 345, 3] -> нет 
// -3; массив [6, 7, 19, 345, 3] -> да

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Выводим результат пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Генерация массива чисел
int[] Gen1DArr(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

// Печать массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int Serch(int[] arr, int e)
{
    int res = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == e)
        {
            res = i;
            break;
        }
    }
    return res;
}

int[] testArr = Gen1DArr(12,-9,9);
Print1DArr(testArr);
int element = ReadData("Какой элемент найти?: ");
int result = Serch(testArr, element);

if(result>0)
{
    PrintData("Элемент найден в позиции: " + result);
}
else
{
    PrintData("В массиве элемент не найден!");
}


