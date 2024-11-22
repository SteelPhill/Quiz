using Quiz.Databases;
using Quiz.Helpers;
using Quiz.Menus.ConsoleMenu;
using System;

namespace Quiz.Commands.MainMenuCommands;

public class RemoveUserCommand : IMenuCommand
{
    private readonly IUserDB userDB;

    public string Description { get; }

    public RemoveUserCommand(string description, IUserDB userDB)
    {
        Description = description;
        this.userDB = userDB;
    }

    public void Execute()
    {
        if (userDB.Users.Count <= 1)
        {
            Console.WriteLine();
            Console.WriteLine("Нет зарегистрированных пользователей!");
            ConsoleWaiting.WaitAnyKey();
            return;
        }

        Console.WriteLine("Список зарегистрированных пользователей:");
        Console.WriteLine();

        for (var i = 1; i < userDB.Users.Count; i++)
            Console.WriteLine($"{i}:\t{userDB.Users[i].Login}");

        Console.WriteLine();

        BeforeEnterTextFromConsoleWriter.Write("Введите номер пользователя из списка");
        var userNumber = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(userNumber))
            return;

        if (int.TryParse(userNumber, out var index))
        {
            if (index < 1 || index > userDB.Users.Count - 1)
                throw new Exception("Пользователя под таким номером нет!");

            userDB.Remove(userDB.Users[index]);

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tПользователь удалён!");
            ConsoleWaiting.WaitAnyKey();
        }
    }
}