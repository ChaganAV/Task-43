int k1 = ReadIntFromConsole($"Введите значение k1");
int b1 = ReadIntFromConsole($"Введите значение b1");
int k2 = ReadIntFromConsole($"Введите значение k2");
int b2 = ReadIntFromConsole($"Введите значение b2");

// Функции
int ReadIntFromConsole(string message)
{
    Console.WriteLine(message);
    int num = 0;
    if(!Int32.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Необходимо ввести число!");    
    return num;
}
