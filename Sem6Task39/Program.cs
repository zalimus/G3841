// Задача №39 
// Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на 
// первом месте, а первый - на последнем и т.д.)
// Например: 
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6] 
// Комментарий: эту задачу можно решить 2 способами: 1) 
// менять числа местами в исходном массиве; 2) создать 
// новый массив и в него записать перевёрнутый исходный 
// массив по элементам


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
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

int len = ReadData("Введите длину массива: ");
int minValue = ReadData("Введите минимальное значение индекса массива: ");
int maxValue = ReadData("Введите максимальное значение индекса массива: ");

int[] arr = Gen1DArr(len, minValue, maxValue);

void InvertedArray(int[] arr)
{
    for(int i = 0; i < (arr.Length)/2; i++)
    {
        (arr[i], arr[arr.Length-1 - i]) = (arr[arr.Length-1 - i], arr[i]);
    }
}
Print1DArr(arr);
InvertedArray(arr);
Print1DArr(arr);

// invertedArray[0] = invertedArray[invertedArray.Length-1];
// invertedArray[invertedArray.Length-1] = invertedArray[0];

// Console.WriteLine(invertedArray[4]);