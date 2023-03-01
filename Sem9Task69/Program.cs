// Задача №69: Напишите программу, которая принимает 
// два числа A и B и возводит A в степень B


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

long RecPowFlow(int a, int b)
{
    if (b <= 1) return a;
    return a * RecPowFlow(a, b - 1);
}

long MyPow(int a, int b)
{
    if (b == 2) return a * a;
    return MyPow(a, b / 2) * MyPow(a, b / 2);
}

int numberA = ReadData("Введите число A: ");
int numberB = ReadData("Введите число B: ");

long res1 = 0;
long res2 = 0;

DateTime d1 = DateTime.Now;
res1 = RecPowFlow(numberA, numberB);
PrintResult("Решение RecPowFlow" + (DateTime.Now - d1));

DateTime d2 = DateTime.Now;
res2 = MyPow(numberA, numberB);
PrintResult("Решение MyPow" + (DateTime.Now - d2));