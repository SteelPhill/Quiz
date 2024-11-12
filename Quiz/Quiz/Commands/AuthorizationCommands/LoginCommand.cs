using Quiz.Databases;
using Quiz.Exceptions;
using Quiz.Helpers;
using Quiz.Menus.ConsoleMenu;
using System;

namespace Quiz.Commands.AuthorizationCommands;

public class LoginCommand : IMenuCommand
{
    private readonly IMenu mainMenu;
    private readonly IUserDB userDB;

    public string Description { get; }

    public LoginCommand(string description, IMenu mainMenu, IUserDB userDB)
    {
        Description = description;
        this.mainMenu = mainMenu;
        this.userDB = userDB;
    }

    public void Execute()
    {
        BeforeEnterTextFromConsoleWriter.Write("Введите логин");
        if (!Utile.UserDataReader.TryReadLogin(out var login))
            throw new BackToPreviousMenuException();

        Console.WriteLine();

        BeforeEnterTextFromConsoleWriter.Write("Введите пароль");
        if (!Utile.UserDataReader.TryReadPassword(out var password))
            throw new BackToPreviousMenuException();

        Utile.CurrentUser = userDB.GetUser(login, password);

        Console.Clear();
        Console.WriteLine("Вход выполнен");
        Console.WriteLine();
        Console.WriteLine($"Пользователь:  {Utile.CurrentUser.Login}");
        Console.WriteLine($"Дата рождения: {Utile.CurrentUser.BirthDate.ToShortDateString()}");
        ConsoleWaiting.WaitAnyKey();

        if (Utile.CurrentUser.Login != Constants.AdminLogin)
            for (var i = 0; i < Constants.AdditionalCommandsNumber; i++) 
                mainMenu.RemoveLastCommand();

        mainMenu.Start();
    }
}