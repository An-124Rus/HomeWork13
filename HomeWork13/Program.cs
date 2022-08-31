internal class Program
{
    private static void Main(string[] args)
    {        
        string name;
        string userInput;

        Console.WriteLine("Приветствуем в консоли!");
        Console.WriteLine("\nВвести имя пользователя - 1");
        Console.WriteLine("Изменить цвет консоли - 2");
        Console.WriteLine("Изменить цвет текста - 3");
        Console.WriteLine("Выход - введите ESC");
        Console.WriteLine("Введите пункт меню: ");
        userInput = Console.ReadLine();

        while (userInput != "ESC")
        {
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Введите имя авторизованного пользователя: ");
                    name = Console.ReadLine();

                    if (name == "Алексей")
                    {
                        Console.WriteLine("Введите символ: ");
                        string symbol = Console.ReadLine();
                        Console.Clear();
                        int sideSymbol = 2;

                        for (int j = 0; j < name.Length + sideSymbol; j++)
                        {
                            Console.Write(symbol);
                        }

                        Console.WriteLine($"\n{symbol}{name}{symbol}");

                        for (int j = 0; j < name.Length + sideSymbol; j++)
                        {
                            Console.Write(symbol);
                        }

                        Console.WriteLine("\nИзменить цвет консоли - 2");
                        Console.WriteLine("Изменить цвет текста - 3");
                        Console.WriteLine("Выход - введите ESC");
                        Console.WriteLine("Введите пункт меню: ");
                        userInput = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Имя пользователя не авторизовано.");
                        Console.WriteLine("\nВвести имя пользователя - 1");
                        Console.WriteLine("Изменить цвет консоли - 2");
                        Console.WriteLine("Изменить цвет текста - 3");
                        Console.WriteLine("Выход - введите ESC");
                        Console.WriteLine("Введите пункт меню: ");
                        userInput = Console.ReadLine();
                    }                    
                    break;

                case "2":
                    Console.WriteLine("Введите цвет консоли Blue (синий) или Red (красный): ");
                    string consoleColor = Console.ReadLine();

                    if (consoleColor == "Blue")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.WriteLine("Ввести имя пользователя - 1");
                        Console.WriteLine("Изменить цвет консоли - 2");
                        Console.WriteLine("Изменить цвет текста - 3");
                        Console.WriteLine("Выход - введите ESC");
                        Console.WriteLine("Введите пункт меню: ");
                        userInput = Console.ReadLine();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("Ввести имя пользователя - 1");
                        Console.WriteLine("Изменить цвет консоли - 2");
                        Console.WriteLine("Изменить цвет текста - 3");
                        Console.WriteLine("Выход - введите ESC");
                        Console.WriteLine("Введите пункт меню: ");
                        userInput = Console.ReadLine();
                    }
                    break;

                case "3":
                    Console.WriteLine("Введите цвет текста Black (чёрный) или Green (зелёный): ");
                    string textColor = Console.ReadLine();

                    if (textColor == "Black")
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine("Ввести имя пользователя - 1");
                        Console.WriteLine("Изменить цвет консоли - 2");
                        Console.WriteLine("Изменить цвет текста - 3");
                        Console.WriteLine("Выход - введите ESC");
                        Console.WriteLine("Введите пункт меню: ");
                        userInput = Console.ReadLine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("Ввести имя пользователя - 1");
                        Console.WriteLine("Изменить цвет консоли - 2");
                        Console.WriteLine("Изменить цвет текста - 3");
                        Console.WriteLine("Выход - введите ESC");
                        Console.WriteLine("Введите пункт меню: ");
                        userInput = Console.ReadLine();
                    }
                    break;
            }
        }
        Console.WriteLine("\nСеанс закончен");
    }
}