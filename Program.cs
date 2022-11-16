int k1 = ReadIntFromConsole($"Введите значение k1");
int b1 = ReadIntFromConsole($"Введите значение b1");
int k2 = ReadIntFromConsole($"Введите значение k2");
int b2 = ReadIntFromConsole($"Введите значение b2");

Console.WriteLine($"Уравнения: y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine($"Ваши значения: {k1},{b1},{k2},{b2}");
Calculation();

// Функции
void Calculation()
{
    Console.WriteLine($"y = {k1}x + {b1}, y = {k2}x + {b2}");
    Console.WriteLine($"y - y = {k1}x + {b1} - ({k2}x + {b2})");
    Console.WriteLine($"{k1}x + {b1} = {k2}x + {b2}");
    Console.WriteLine($"{k1-k2}x = {b1-b2}");
    double x = (double)(b1-b2)/(k1-k2);
    Console.WriteLine($"x = {x}");
    double y = (double)k2*x + b2;
    Console.WriteLine($"y = {k2}*{x} + {b2}");
    Console.WriteLine($"y = {y}");
    Console.WriteLine($"Точка пересечения: ({x}; {y})");
}

int ReadIntFromConsole(string message)
{
    Console.WriteLine(message);
    int num = 0;
    if (!Int32.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Необходимо ввести число!");
    return num;
}
