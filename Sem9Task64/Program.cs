// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Чтение данных из консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

// 1 2 3 4 ... n
// n = 5

// num = 5  5 4 3 2 1 " "
// num = 4      4 3 2 1 " "
// num = 3          3 2 1 " "
// num = 2              2 1 " "
// num = 1                  1 " "
// num = 0                      " "

// Метод выводит числа в промежутке от N до 1
string LineGenRec(int num)
{
    if (num == 0)
    {
        return string.Empty;
    }
    else
    {
        return num + " " + LineGenRec(num - 1);
    }

}

int number = ReadData("Введите число N: ");
string resultLine = LineGenRec(number);
PrintResult(resultLine);