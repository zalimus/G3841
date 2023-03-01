// Задача №65: Задайте число M и N. Напишите программу, 
// которая найдет все натуральные элементы от M до N.


// Чтение данных из консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

string RecLineMN(int m, int n)
{
    if (m >= n)
    {
        return n.ToString();
    }
    else
    {
        return m + " " + RecLineMN(m + 1, n);
    }

}

// 1 шаг
// string RecLineMN(5, 10)
// {
//     if (5 >= 10)
//     {
//         return n.ToString();
//     }
//     else
//     {
//         return 5 + " " + RecLineMN(5 + 1, 10);   5 + " " + 6 + " " + 7 + " " + 8 + " " + 9 + " " + 10
//     }

// }
// 2 шаг
// string RecLineMN(6, 10)
// {
//     if (6 >= 10)
//     {
//         return n.ToString();
//     }
//     else
//     {
//         return 6 + " " + RecLineMN(6 + 1, 10);   6 + " " + 7 + " " + 8 + " " + 9 + " " + 10
//     }

// }
// 3 шаг
// string RecLineMN(7, 10)
// {
//     if (7 >= 10)
//     {
//         return n.ToString();
//     }
//     else
//     {
//         return 7 + " " + RecLineMN(7 + 1, 10);   7 + " " + 8 + " " + 9 + " " + 10
//     }

// }
// 4 шаг
// string RecLineMN(8, 10)
// {
//     if (8 >= 10)
//     {
//         return n.ToString();
//     }
//     else
//     {
//         return 8 + " " + RecLineMN(8 + 1, 10);   8 + " " + 9 + " " + 10
//     }
// }
// 5 шаг
// string RecLineMN(9, int 10)
// {
//     if (9 >= 10)
//     {
//         return n.ToString();
//     }
//     else
//     {
//         return 9 + " " + RecLineMN(9 + 1, 10);   9 + " " + 10
//     }
// }
// 6 шаг
// string RecLineMN(10, 10)
// {
//     if (10 >= 10)
//     {
//         return 10.ToString();                    
//     }
//     else
//     {
//         return m + " " + RecLineMN(m + 1, 10); 
//     }
// }

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
string res = RecLineMN(numM, numN);
PrintResult(res);