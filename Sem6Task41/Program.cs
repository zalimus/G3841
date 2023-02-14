// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// (от Голикова А.С.) * Пользователь вводит число нажатий, затем программа
// следит за нажатиями с клавиатуры и выдает сколько чисел больше 0 было введено.



Console.WriteLine("Введите числа через пробел: ");
string input = Console.ReadLine() ?? "0";
string[] numbers = input.Split(' ');

int CountPositiveNumbers(string[] numbers)
{
    int count = 0;
    foreach (string num in numbers)
    {
        if (int.Parse(num) > 0)
        {
            count++;
        }
    }
    return count;
}

int count = CountPositiveNumbers(numbers);
Console.WriteLine("Количество положительных чисел: " + count);