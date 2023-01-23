// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// // Вариант 1
// // Считываем данные с консоли, проверяем на null, парсим
// int day = int.Parse(Console.ReadLine()??"0");

// if (day > 7 || day < 1)
// {
//     Console.WriteLine("Не день недели");
// }
// else
// {
//     if (day > 5)
//     {
//         Console.WriteLine("Выходной");
//     }
//     else
//     {
//         Console.WriteLine("Выходной");
//     }
// }


// Вариант 2

// Считываем данные с консоли, проверяем на null, парсим
int day = int.Parse(Console.ReadLine()??"0");

if (day > 7 || day < 1)
{
    Console.WriteLine("Не день недели");
}
else
{
    Dictionary<int, string> week = new Dictionary<int, string>
{
    { 1, "Рабочий" },
    { 2, "Рабочий" },
    { 3, "Рабочий" },
    { 4, "Рабочий" },
    { 5, "Рабочий" },
    { 6, "Выходной" },
    { 7, "Выходной" },
};

    Console.WriteLine(week[day]);
}