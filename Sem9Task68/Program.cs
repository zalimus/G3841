// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

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

// Метод вычисления функции Аккермана
int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    else
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
int res = Ackerman(numM, numN);
PrintResult(res);