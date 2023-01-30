// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет 
// 23432 -> да 
// 12821 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

// Метод читает данные от пользователя
int ReadData(string msg) 

{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Выводим результат пользователю
void PrintQuterAnswer(bool palin)
{
    if (palin == true) Console.WriteLine("Число является палиндромом");
    if (palin == false) Console.WriteLine("Число не является палиндромом");
}

// Вычисляем результат
bool PalinTest(int n)
{
    bool res = false;
    int digit1 = n/10000;
    int digit2 = (n/1000)%10;
    int digit3 = (n/10)%10;
    int digit4 = n%10;

    res = (digit1 == digit4) && (digit2 == digit3)?true:false;

    return res;
}

int num = ReadData("Введите пятизначное число: ");
bool value = PalinTest(num);

PrintQuterAnswer(value);



