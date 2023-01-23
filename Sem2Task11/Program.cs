// // Сгенерировать трехзначное число и удалить вторую цифру 

// //Создание объекта для генерации чисел
// System.Random newSintezator = new System.Random();
// //Получить очередное (в данном случае - первое) случайное число
// int num = newSintezator.Next(100, 1000);

// // Деление числа на 100 для получения первй цифры
// int digitFirst = num/100;
// // Остаток от деления на 10 будет третьей цифрой числа
// int digitLast = num%10;
// // Вывод сгенерированного числа
// Console.WriteLine(num);
// // Вывод первой и третьей цифры
// Console.WriteLine(digitFirst*10 + digitLast);


// Вариант 2
//Создание объекта для генерации чисел
System.Random newSintezator = new System.Random();
//Получить очередное (в данном случае - первое) случайное число
int num = newSintezator.Next(100, 1000);
// Вывод сгенерированного числа
Console.WriteLine(num);

// Преобразование числа в текстовый формат
string value = num.ToString();
// Разбиение строки на символы
char[] numberArray = value.ToCharArray();
// Вывод первой и третьей цифры
Console.WriteLine(numberArray[0] + "" + numberArray[2]);







