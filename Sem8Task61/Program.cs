// Задача №61
// Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного 
// треугольника


// Вычисляем факториал
float Factor(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод строит треугольник Паскаля
void PrintPascalTriangle(int nRow)
{
    for (int i = 0; i < nRow; i++)
    {
        for (int j = 0; j <= nRow - i; j++)
        {
            Console.Write(" ");
        }

        for (int j = 0; j <= i; j++)
        {
            // создаем пробелы между элементами треугольника
            Console.Write(" ");
            // формула вычисления элементов треугольника
            Console.Write(Factor(i) / (Factor(j) * Factor(i - j)));
        }
        Console.WriteLine();
    }
}

int countRow = ReadData("Введите количество строк треугольника паскаля");
PrintPascalTriangle(countRow);