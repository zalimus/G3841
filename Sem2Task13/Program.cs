// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// // Вариант 1
// // Считываем данные с консоли, проверяем на null, парсим
// char[] digit = Console.ReadLine().ToCharArray();

// if (digit.Length>=3)
// {
//     // Вывод третьей цифры
//     Console.WriteLine(digit[2]);
// }
// else
// {
//     // Сообщение, если нет третьей цифры
//     Console.WriteLine("Третьей цифры нет");
// }


// Вариант 2
// Считываем данные с консоли, проверяем на null, парсим
int num = int.Parse(Console.ReadLine()??"0");

if (num > 100)
{
    int numLength = num.ToString().Length;
    int threeDigitNumber = num/(int)Math.Pow(10, numLength-3);
    int result = threeDigitNumber%10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}