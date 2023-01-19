// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из 
// этих чисел.
//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22


// Считываем данные с консоли
string? inputNumLineA = Console.ReadLine();
string? inputNumLineB = Console.ReadLine();
string? inputNumLineC = Console.ReadLine();


// Проверяем, чтобы данные были не пустыми
if (inputNumLineA!=null && inputNumLineB!=null && inputNumLineC!=null)
{
    // Парсим введеное число
    int numberA = int.Parse(inputNumLineA);
    int numberB = int.Parse(inputNumLineB);
    int numberC = int.Parse(inputNumLineC);

    if(numberA > numberB)
    {
        if(numberA > numberC)
        {
            Console.WriteLine(numberA);
        }
        else
        {
            Console.WriteLine(numberC);

        }
    }
    else
    {
        if(numberB > numberC)
        {
            Console.WriteLine(numberB);
        }
        else
        {
            Console.WriteLine(numberC);

        }
    }
}