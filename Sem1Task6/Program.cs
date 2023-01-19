// Напишите программу, которая на вход принимает число и выдаёт, является ли число 
// чётным (делится ли оно на два без остатка).
//  4 -> да
//  -3 -> нет
//  7 -> нет

// Считываем данные с консоли
string? inputNumLine = Console.ReadLine();

// Проверяем, чтобы данные были не пустыми
if(inputNumLine != null)
{
    // Парсим введеное число
    int number = int.Parse(inputNumLine);

    if(number%2==0)
    {
        Console.WriteLine("число четное");
    }
    else
    {
        Console.WriteLine("число не четное");
    }

}