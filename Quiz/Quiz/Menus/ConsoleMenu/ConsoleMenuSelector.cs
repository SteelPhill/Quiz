using System;
using System.Collections.Generic;

namespace Quiz.Menus.ConsoleMenu;

public class ConsoleMenuSelector : IMenuSelector
{
    private readonly List<IMenuCommand> commands;
    private readonly IMenuWriter menuWriter;

    public ConsoleMenuSelector(List<IMenuCommand> commands, string title)
    {
        this.commands = commands;
        menuWriter = new ConsoleMenuWriter(commands, title);
    }

    public void Select(ref int selector)
    {
        do
        {
            Console.Clear();
            menuWriter.Write(ref selector);

            var key = Console.ReadKey().Key;

            if (key == ConsoleKey.DownArrow && selector < commands.Count)
                selector++;
            else if (key == ConsoleKey.UpArrow && selector > 0)
                selector--;
            else if (key == ConsoleKey.Enter)
                return;
            else if (key == ConsoleKey.Escape)
            {
                selector = commands.Count;
                return;
            }

        } while (true);
    }
}