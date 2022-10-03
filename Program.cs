while (true)
{
    Console.WriteLine("\n   Выберите действие:\n" +
                      "1. Игра \"Угадай число\" \n" +
                      "2. Таблица умножения \n" +
                      "3. Вывод делителей числа \n" +
                      "4. Выход\n");
    string choice = Console.ReadLine();
    Console.WriteLine("\n");
    switch (choice)
    {
        case "1":
            GuessNumber();
            break;
        case "2":
            TableMultiply();
            break;
        case "3":
            AllDivisors();
            break;
        case "4":
            Exit();
            break;
    }
}

static void TableMultiply()
{
    int[,] Table = new int[10, 10];
    for (int row = 0; row < 10; row++)
    {
        for (int col = 0; col < 10; col++)
        {
            Table[row, col] = (row + 1) * (col + 1);
            Console.Write(Table[row, col] + "\t");
        }
        Console.WriteLine("\n\n");
    }
}

static void GuessNumber()
{
    Random x = new();
    int numc = x.Next(101);
    Console.WriteLine("Компьютер загадал целое число от 0 до 100\n" +
                      "Попробуй его угадть! (подсказок не будет, ибо мне лень)\n" +
                      "Удачи!");
    while (true)
    {
        string nump = Console.ReadLine();
        int intnump = Convert.ToInt32(nump);
        if (intnump != numc)
        {
            Console.WriteLine("Поробуй ещё!\n");
        }
        else
        {
            Console.WriteLine("Молодец! \n\n");
            break;
        }
    }
}

static void AllDivisors()
{
    double i = 0;
    Console.WriteLine("Введите число:");
    string num = Console.ReadLine();
    double intnum = Convert.ToDouble(num);
    Console.Write("\nДелителями числа являются: ");
    do
    {
        if (intnum % i == 0)
        {
            Console.Write(i + " ");
        }
        i++;
    } while (i != intnum + 1);
    Console.WriteLine("");
    
}

static void Exit()
{
    Console.WriteLine("\n Поздравляю, Вы вышли из пограммы!\n\n");
    Environment.Exit(0);
}