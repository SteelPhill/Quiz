using Quiz.Helpers;
using Quiz.Menus.ConsoleMenu;
using System;

namespace Quiz.Commands.SettingsCommands;

public class ChangeBirthDateCommand : IMenuCommand
{
    public string Description { get; }

    public ChangeBirthDateCommand(string description)
    {
        Description = description;
    }

    public void Execute()
    {
        Console.WriteLine($"Текущий пользователь: {Utile.CurrentUser.Login}");
        Console.WriteLine();

        BeforeEnterTextFromConsoleWriter.Write("Введите пароль");
        if (!Utile.UserDataReader.TryReadPassword(out var password))
            return;

        if (password != Utile.CurrentUser.Password)
            throw new Exception("Неверный пароль!");

        Console.WriteLine();

        BeforeEnterTextFromConsoleWriter.Write("Введите новую дату рождения");
        if (!Utile.UserDataReader.TryReadDate(out var newBirthDate))
            return;

        Utile.CurrentUser.BirthDate = newBirthDate;

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("\tДата рождения изменена!");
        ConsoleWaiting.WaitAnyKey();
    }
}