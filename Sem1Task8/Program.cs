// Считываем данные с консоли
string? inputNum = Console.ReadLine();

// Проверяем, чтобы данные были не пустыми
if(inputNum!=null)
{
    // Парсим введеное число
    int inputNumber1 = int.Parse(inputNum);

    // Создаем пустую строку
    string result = string.Empty;

    for(int i = 2; i < inputNumber1; i = i+2)
    {
        result = result + i + ",";
        
    }
    if(inputNumber1%2 == 0)
    {
        result = result + inputNumber1;  
    }
    Console.WriteLine(result);
}
