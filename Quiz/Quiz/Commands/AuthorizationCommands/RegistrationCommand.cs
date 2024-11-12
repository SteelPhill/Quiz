using Quiz.Databases;
using Quiz.Entities;
using Quiz.Exceptions;
using Quiz.Helpers;
using Quiz.Menus.ConsoleMenu;
using System;

namespace Quiz.Commands.AuthorizationCommands;

public class RegistrationCommand : IMenuCommand
{
    private readonly IMenu mainMenu;
    private readonly IUserDB userDB;

    public string Description { get; }

    public RegistrationCommand(string description, IMenu mainMenu, IUserDB userDB)
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

        Console.WriteLine();

        BeforeEnterTextFromConsoleWriter.Write("Введите дату рождения");
        if (!Utile.UserDataReader.TryReadDate(out var birthDate))
            throw new BackToPreviousMenuException();

        Utile.CurrentUser = new User(login, password, birthDate);

        userDB.Add(Utile.CurrentUser);

        Console.Clear();
        Console.WriteLine("Регистрация выполнена");
        Console.WriteLine();
        Console.WriteLine($"Пользователь:  {Utile.CurrentUser.Login}");
        Console.WriteLine($"Дата рождения: {Utile.CurrentUser.BirthDate.ToShortDateString()}");
        ConsoleWaiting.WaitAnyKey();

        for (var i = 0; i < Constants.AdditionalCommandsNumber; i++)
            mainMenu.RemoveLastCommand();

        mainMenu.Start();
    }
}