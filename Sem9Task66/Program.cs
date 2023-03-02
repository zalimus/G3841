// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Чтение данных из консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Печать результата
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

// Метод находит сумму элементов в промежутке от M до N
int RecSumMN(int m, int n)
{
    if (m >= n)
    {
        return n;
    }
    else
    {
        return m + RecSumMN(m + 1, n);
    }
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
int res = numM < numN ? RecSumMN(numM, numN) : RecSumMN(numN, numM);
PrintResult(res);