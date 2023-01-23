// Напишите программу, которая будет принимать на вход два числа
// и выводить является ли одно квадратом другого.

int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");
// if(num1*num1 == num2)
// {
//     Console.WriteLine("Второе число квадрат первого");
// }
// else
// {
// if (num2*num2 == num1)
// {
//     Console.WriteLine("Первое число квадрат второго");
// }
// else
// {
//     Console.WriteLine("Нет");
// }
// }

TestSQRT(num1,num2);
TestSQRT(num2,num1);

void TestSQRT(int i, int j)
{
    if ((int)Math.Pow(i, 2) == j)
    {
        Console.WriteLine("число" + j + "квадрат" + i);
    }
    else
    {
        Console.WriteLine("число" + j + "не является квадратом" + i);
    }
}