// Задача №37
// Найдите произведение пар чисел в одномерном 
// массиве. Парой считаем первый и последний 
// элемент, второй и предпоследний и т.д. Результат 
// запишите в новом массиве.
// Например:
// [1 2 3 4 5] -> 5 8 3 
// [6 7 3 6] -> 36 21



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

int[] ConvertArr(int[] arr)
{
    int[] resArr = new int[(arr.Length/2)+1];
    for (int i = 0; i < arr.Length/2; i++)
    {
       resArr[i]=arr[i]*arr[arr.Length-1-i];
    }
    return resArr;
}


int[] testArr = Gen1DArr(13,0,9);
Print1DArr(testArr);
int[] convArr = ConvertArr(testArr);
Print1DArr(convArr);
Print1DArr(testArr);
