// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в 
// числе.
// 452 -> 11 
// 82 -> 10 
// 9012 -> 12
// * Сделать оценку времени алгоритма через вещественные числа и строки

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

int SumSym(int num)
{
    int res = 0;
    while(num > 0)
    {
        res = res+num%10;
        num = num/10;
    }
    return res;
}

int number = ReadData("Введите число:");

int sum = SumSym(number);

PrintData("Сумма цифр: ", sum);