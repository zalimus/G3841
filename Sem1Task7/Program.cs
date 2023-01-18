// Считываем данные с консоли
string? inputNumLine = Console.ReadLine();

// Проверяем, чтобы данные не были пустыми
if(inputNumLine!=null)
{
    // Парсим введенное число
    int inputNumberA = int.Parse(inputNumLine);

    // Вводим промежуточное значение
    int lastDigit = inputNumberA%10;
    Console.WriteLine(lastDigit);
}