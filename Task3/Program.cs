//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Welcome to the \"Check Odd or Even\" app!"); //Приветсвие

Console.Write("Please enter the number to check:"); // Запрашиваем у пользователя число для проверки
int a = Int32.Parse(Console.ReadLine());

if ( a % 2 ==0)
    Console.Write($"The number \"{a}\" you entered is Even"); // Выводим результат проверки на четность
else
    Console.Write($"The number \"{a}\" you entered is Odd"); // Выводим результат проверки на четность

