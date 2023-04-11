Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "nastya")
    {
        Console.WriteLine("Hey, Anastasia");
    }
else 
    {
        Console.Write("Hello, ");
        Console.WriteLine(username);
    }