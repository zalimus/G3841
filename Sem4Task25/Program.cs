// №25 Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень


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

int Pow(int a, int b)
{
    int res = 1;
    while(b > 0)
    {
        b = b-1;
        res = res * a;
    }
    return res;
}

int numberA = ReadData("Введите число A:");
int numberB = ReadData("Введите число B:");

int RaiseToPower = Pow(numberA, numberB);


PrintData("Число A в степени B равен: ", RaiseToPower);