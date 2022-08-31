internal class Program
{
    private static void Main(string[] args)
    {        
        string name;
        string userInput;

        Console.WriteLine("Приветствуем в консоли!");
        Console.WriteLine("\nВвести имя пользователя -  введите SetName");
        Console.WriteLine("Изменить цвет консоли - введите ChangeConsoleColor");
        Console.WriteLine("Изменить цвет текста - введите ChangeTextColor");
        Console.WriteLine("Выход - введите ESC");
        Console.WriteLine("Введите команду: ");
        userInput = Console.ReadLine();

        while (userInput != "ESC")
        {
            switch (userInput)
            {
                case "SetName":
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

                        Console.WriteLine("\nИзменить цвет консоли - введите ChangeConsoleColor");
                        Console.WriteLine("Изменить цвет текста - введите ChangeTextColor");
                        Console.WriteLine("Выход - введите ESC");
                        Console.WriteLine("Введите команду: ");
                        userInput = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Имя пользователя не авторизовано.");
                        Console.WriteLine("\nВвести имя пользователя - введите SetName");
                        Console.WriteLine("Изменить цвет консоли - введите ChangeConsoleColor");
                        Console.WriteLine("Изменить цвет текста - введите ChangeTextColor");
                        Console.WriteLine("Выход - введите ESC");
                        Console.WriteLine("Введите команду: ");
                        userInput = Console.ReadLine();
                    }                    
                    break;

                case "ChangeConsoleColor":
                    Console.WriteLine("Введите цвет консоли Blue (Синий) или Red (Красный): ");
                    string consoleColor = Console.ReadLine();

                    if (consoleColor == "Blue" || consoleColor == "Синий")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.WriteLine("Ввести имя пользователя - введите SetName");
                        Console.WriteLine("Изменить цвет консоли - введите ChangeConsoleColor");
                        Console.WriteLine("Изменить цвет текста - введите ChangeTextColor");
                        Console.WriteLine("Выход - введите ESC");
                        Console.WriteLine("Введите команду: ");
                        userInput = Console.ReadLine();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("Ввести имя пользователя - введите SetName");
                        Console.WriteLine("Изменить цвет консоли - введите ChangeConsoleColor");
                        Console.WriteLine("Изменить цвет текста - введите ChangeTextColor");
                        Console.WriteLine("Выход - введите ESC");
                        Console.WriteLine("Введите команду: ");
                        userInput = Console.ReadLine();
                    }
                    break;

                case "ChangeTextColor":
                    Console.WriteLine("Введите цвет текста Black (Чёрный) или Green (Зелёный): ");
                    string textColor = Console.ReadLine();

                    if (textColor == "Black" || textColor == "Чёрный")
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine("Ввести имя пользователя - введите SetName");
                        Console.WriteLine("Изменить цвет консоли - введите ChangeConsoleColor");
                        Console.WriteLine("Изменить цвет текста - введите ChangeTextColor");
                        Console.WriteLine("Выход - введите ESC");
                        Console.WriteLine("Введите команду: ");
                        userInput = Console.ReadLine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("Ввести имя пользователя - введите SetName");
                        Console.WriteLine("Изменить цвет консоли - введите ChangeConsoleColor");
                        Console.WriteLine("Изменить цвет текста - введите ChangeTextColor");
                        Console.WriteLine("Выход - введите ESC");
                        Console.WriteLine("Введите команду: ");
                        userInput = Console.ReadLine();
                    }
                    break;
            }
        }
        Console.WriteLine("\nСеанс закончен");
    }
}