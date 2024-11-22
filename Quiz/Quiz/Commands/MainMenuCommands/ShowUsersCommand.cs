using Quiz.Databases;
using Quiz.Helpers;
using Quiz.Menus.ConsoleMenu;
using System;

namespace Quiz.Commands.MainMenuCommands;

public class ShowUsersCommand : IMenuCommand
{
    private readonly IUserDB userDB;

    public string Description { get; }

    public ShowUsersCommand(string description, IUserDB userDB)
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

        for (var i = 1; i < userDB.Users.Count; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Пользователь:  {userDB.Users[i].Login}");
            Console.WriteLine($"Дата рождения: {userDB.Users[i].BirthDate.ToShortDateString()}");
        }

        ConsoleWaiting.WaitAnyKey();
    }
}