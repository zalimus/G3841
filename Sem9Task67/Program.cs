// Задача №67: Написать программу, которая принимает 
// на вход число и возвращает сумму цифр в числе

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

// Сумма цифр в числе рекурентно
int RecSumDig(int n)
{
    if (n <= 10) return n;
    return n % 10 + RecSumDig(n / 10);
}

// Сумма цифр в числе
int SumDigit(int n)
{
    int res = 0;
    while (n > 0)
    {
        res = res + n % 10;
        n = n / 10;
    }
    return res;
}

int numberN = ReadData("Введите число N: ");
int sum1 = RecSumDig(numberN);
PrintResult(sum1);
int sum2 = SumDigit(numberN);
PrintResult(sum2);