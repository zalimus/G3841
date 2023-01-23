// Напишите программу, которая будет принимать на вход два числа
// и выводить является ли второе число кратным первому, если второе
// число не кратно первому, то программа выводит остаток от деления.

int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");
int res = num2%num1;
if(res == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно: " + res);
}