/*------------------------------------------------------------------------------------------------------------------------
Составить программу:
а) вычисления значения функции y=7x^2+3x+6 при любом значении x;
б) вычисления значения функции x=12a^2+7a+12 при любом значении a;
------------------------------------------------------------------------------------------------------------------------*/

int Func1(int x)
{
    const int a=7, b=3, c=6, n=2;
    return a*x*x+b*x+c;
}

int Func2(int a)
{
    return 12*a*a+7*a+12;
}

int Param, res;
string FuncNum;

while (true)
{
    Console.WriteLine("Выберите необходимую к вычислению функцию: \n 1 - для вычисления 7x^2+3x+6 \n 2 - для вычисления 12a^2+7a+12 \n q - для выхода");
    FuncNum = Console.ReadLine();

    
    switch(FuncNum)
    {
        case "1": 
            Console.WriteLine("Введите значение параметра функции:");
            Param = Convert.ToInt32(Console.ReadLine());
            res = Func1(Param);
            Console.WriteLine($"Результат выполнения фунции 7x^2+3x+6 с аргументом {Param} : {res}");
            Console.WriteLine("Для продолжения нажмите любую кнопку");
            Console.ReadLine();
            break;

        case "2": 
            Console.WriteLine("Введите значение параметра функции:");
            Param = Convert.ToInt32(Console.ReadLine());
            res = Func2(Param);
            Console.WriteLine($"Результат выполнения фунции 12a^2+7a+12 с аргументом {Param} : {res}");
            Console.WriteLine("Для продолжения нажмите любую кнопку");
            Console.ReadLine();
            break;

        case "q":
            return;

        default:
            Console.WriteLine("Ошибка ввода! Пожалуйста, попробуйте еще раз.");
            Console.WriteLine("Для продолжения нажмите любую кнопку");
            Console.ReadLine();
            break;
    }
}
