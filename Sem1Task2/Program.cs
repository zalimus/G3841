// Напишите программу, которая на вход принимает два числа и выдаёт, какое число 
// большее, а какое меньшее.
//  a = 5; b = 7 -> max = 7
//  a = 2 b = 10 -> max = 10
//  a = -9 b = -3 -> max = -3

// Считываем данные с консоли
string? inputNumLine1 = Console.ReadLine();
string? inputNumLine2 = Console.ReadLine();

// Проверяем, чтобы данные были не пустыми
if (inputNumLine1!=null && inputNumLine2!=null)
{
    // Парсим введеное число
    int number1 = int.Parse(inputNumLine1);
    int number2 = int.Parse(inputNumLine2);

    if(number1 > number2)
    {
        Console.WriteLine("число 1 больше числа 2");
    }
    else
    {
        Console.WriteLine("число 2 больше числа 1");
    }
}