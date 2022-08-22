// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Welcome to the \"Show all even from 1 to Num\" app!"); //Приветсвие

Console.Write("Please enter the number N:"); // Запрашиваем у пользователя число N

int num = Int32.Parse(Console.ReadLine());

int num_count = 0;                                  // Переменная для форматирования вывода в консоль

for (int i=1; i<=num; i++)                          // Запускаем цикл от 1 до N
    if(i%2 == 0)                                    // Проверяем на четность
    {
        if(num_count++%10 == 0)                               
            Console.WriteLine();                    // Через каждые 10 чисел переходим на новую строку
        Console.Write(i.ToString("000  "));           // Выводим число соответствующее условию задачи в консоль
    }
    

