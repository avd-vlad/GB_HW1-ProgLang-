//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a, b, max;

Console.WriteLine("Welcome to the find 'Max of Two' app!"); //Приветсвие

Console.Write("Please enter first number:"); // Запрашиваем у пользователя первое число
a = Int32.Parse(Console.ReadLine());

Console.Write("Please enter first number:"); // Запрашиваем у пользователя второе число
b = Int32.Parse(Console.ReadLine());

max = a; //инициализируем max

if (b > max)  // Производим сравнение
    max = b;  // Изменяем значение max

Console.Write($"The max number of {a} and {b} is {max}"); //Выводим результат

