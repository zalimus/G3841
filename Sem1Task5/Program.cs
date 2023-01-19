// Считываем данные с консоли
string? inputNumLine = Console.ReadLine();

// Проверяем, чтобы данные не были пустыми
if(inputNumLine!=null)
{
    // Парсим введенное число
    int inputNumberA = int.Parse(inputNumLine);

    // Вводим промежуточное значение
    int inputNumberC = inputNumberA*(-1);

    // Выходные значения
    string outNumLine = string.Empty;

    while(inputNumberC<inputNumberA)
    {
        outNumLine = outNumLine+inputNumberC+",";
        inputNumberC=inputNumberC+1;
    }
    outNumLine=outNumLine+inputNumberA;
    Console.WriteLine(outNumLine);
}

