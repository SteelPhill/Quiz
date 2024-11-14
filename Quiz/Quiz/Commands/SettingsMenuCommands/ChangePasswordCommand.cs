using Quiz.Helpers;
using Quiz.Menus.ConsoleMenu;
using System;

namespace Quiz.Commands.SettingsCommands;

public class ChangePasswordCommand : IMenuCommand
{
    public string Description { get; }

    public ChangePasswordCommand(string description)
    {
        Description = description;
    }

    public void Execute()
    {
        Console.WriteLine($"Текущий пользователь: {Utile.CurrentUser.Login}");
        Console.WriteLine();

        BeforeEnterTextFromConsoleWriter.Write("Введите старый пароль");
        if (!Utile.UserDataReader.TryReadPassword(out var oldPassword))
            return;

        if (oldPassword != Utile.CurrentUser.Password)
            throw new Exception("Неверный пароль!");

        Console.WriteLine();

        BeforeEnterTextFromConsoleWriter.Write("Введите новый пароль");
        if (!Utile.UserDataReader.TryReadPassword(out var newPassword))
            return;

        Utile.CurrentUser.Password = newPassword;

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("\tПароль изменён!");
        ConsoleWaiting.WaitAnyKey();
    }
}