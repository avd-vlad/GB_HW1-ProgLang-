//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a, b, c, max;

Console.WriteLine("Welcome to the find \"Max of Three\" app!"); //Приветсвие

Console.Write("Please enter first number:"); // Запрашиваем у пользователя первое число
a = Int32.Parse(Console.ReadLine());

Console.Write("Please enter second number:"); // Запрашиваем у пользователя второе число
b = Int32.Parse(Console.ReadLine());

Console.Write("Please enter third number:"); // Запрашиваем у пользователя третье число
c = Int32.Parse(Console.ReadLine());

// Solution - 1
/*
max = a; //инициализируем max

if (b > max)  // Производим сравнение
    max = b;  // Изменяем значение max

if (c > max)  // Производим сравнение
    max = c;  // Изменяем значение max
*/
// Solution - 2

if(a > b)     // Производим сравнения
    if(a > c)
        max=a;
    else
        max=c;
else
    if(b > c)
        max=b;
    else
        max=c;

Console.Write($"The max number of {a}, {b} and {c} is {max}"); //Выводим результат


