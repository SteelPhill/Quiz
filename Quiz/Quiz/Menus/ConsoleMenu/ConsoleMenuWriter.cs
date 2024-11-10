using System;
using System.Collections.Generic;

namespace Quiz.Menus.ConsoleMenu;

public class ConsoleMenuWriter : IMenuWriter
{
    private readonly List<IMenuCommand> commands;
    private readonly string title;

    public ConsoleMenuWriter(List<IMenuCommand> commands, string title)
    {
        this.commands = commands;
        this.title = title;
    }

    public void Write(ref int selector)
    {
        Console.WriteLine(Constants.QuizLogo);
        Console.WriteLine();

        if (Utile.CurrentUser != null)
        {
            Console.WriteLine($"Текущий пользователь: {Utile.CurrentUser.Login}");
            Console.WriteLine();
        }

        Console.WriteLine(title);
        Console.WriteLine();

        for (var i = 0; i < commands.Count; i++)
        {
            if (selector == i)
                Utile.BlackOnWhiteTextWriter.WriteLine(commands[i].Description);
            else
                Console.WriteLine(commands[i].Description);
        }

        Console.WriteLine();

        if (selector == commands.Count)
            Utile.BlackOnWhiteTextWriter.WriteLine("Выход");
        else
            Console.WriteLine("Выход");
    }
}