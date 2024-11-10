using Quiz.Helpers;
using System;
using System.Collections.Generic;

namespace Quiz.Menus.ConsoleMenu;

public class ConsoleMenu : IMenu
{
    private readonly List<IMenuCommand> commands = [];
    private readonly bool isBackAfterExecute;
    private readonly IMenuSelector menuSelector;

    public ConsoleMenu(string title, bool isBackAfterExecute = false)
    {
        this.isBackAfterExecute = isBackAfterExecute;
        menuSelector = new ConsoleMenuSelector(commands, title);
    }

    public void AddCommand(IMenuCommand command)
    {
        commands.Add(command);
    }

    public void RemoveCommand(IMenuCommand command)
    {
        commands.Remove(command);
    }

    public void RemoveLastCommand()
    {
        if (commands.Count != 0)
            commands.RemoveAt(commands.Count - 1);
    }

    public void Start()
    {
        var selector = 0;

        while (true)
        {
            menuSelector.Select(ref selector);

            if (selector == commands.Count)
                return;

            Console.Clear();

            var isExecute = TryExecuteCommand(selector);

            if (!isExecute)
                continue;

            if (isBackAfterExecute)
                return;
        }
    }

    private bool TryExecuteCommand(int selector)
    {
        try
        {
            commands[selector].Execute();
        }
        catch (Exception ex)
        {     
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
            ConsoleWaiting.WaitAnyKey();
            return false;
        }

        Console.WriteLine();
        Console.Clear();
        return true;
    }
}