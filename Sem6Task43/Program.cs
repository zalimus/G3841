// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// (от Голикова А.С.) * Найдите площадь треугольника образованного пересечением 3 прямых

double ReadData(string msg)
{
    Console.WriteLine(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}

double b1 = ReadData("Введите число b1: ");
double b2 = ReadData("Введите число b2: ");
double k1 = ReadData("Введите число k1: ");
double k2 = ReadData("Введите число k2: ");


void IntersectionX(double b1, double b2, double k1, double k2)
{
    double x = (b2-b1)/(k1-k2);
    Console.Write(x + "; ");
}

void IntersectionY(double b1, double b2, double k1, double k2)
{
    double y = k1*(b2-b1)/(k1-k2)+b1;
    Console.WriteLine(y);
}

IntersectionX(b1, b2, k1, k2);
IntersectionY(b1, b2, k1, k2);