﻿// Задача №20 
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 2D пространстве.
// Например:
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Выводим результат пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}


double CalcLen(int x1, int x2, int y1, int y2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

    return res;
}

// Вводим координаты точек
int coordX1 = ReadData("Введите координату x1");
int coordX2 = ReadData("Введите координату x2");
int coordY1 = ReadData("Введите координату x3");
int coordY2 = ReadData("Введите координату x4");

// Вычисляем длину
double len = CalcLen(coordX1, coordX2, coordY1, coordY2);

// Выдаем результат
PrintData("Расстояние между точками: ", len);