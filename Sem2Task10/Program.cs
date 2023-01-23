// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1



// // Вариант 1
// // Считываем данные с консоли, проверяем на null, парсим
// int num = int.Parse(Console.ReadLine()??"0");

// if ((num > 99) && (num <1000))
// {
//     int res = num/10;
//     res = res%10;

//     Console.WriteLine(res);
// }
// else
// {
//     Console.WriteLine("Число не является трехзначным");
// }



// Вариант 2
// Считываем данные с консоли, проверяем на null, парсим
int num = int.Parse(Console.ReadLine()??"0");

if ((num > 99) && (num <1000))
{
    // Преобразование числа в текстовый формат
    string value = num.ToString();
    // Разбиение строки на символы
    char[] numberArray = value.ToCharArray();
    
    // Вывод второй цифры
    Console.WriteLine(numberArray[1]);
}
else
{
    Console.WriteLine("Число не является трехзначным");
}
