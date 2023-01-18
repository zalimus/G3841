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

// string? inputNum = Console.ReadLine();

// if(inputNum!=null)
// {
//     int inputNumber1 = int.Parse(inputNum);
//     string result = string.Empty;
//     for(int i = 2; i < inputNumber1; i = i+2)
//     {
//         result = result + i + ",";
//     }
//     if(inputNumber1%2 == 0)
//     {
//         result = result + inputNumber1;
//         Console.WriteLine(result);
//     }
// }