using Quiz.Menus.ConsoleMenu;

namespace Quiz.Commands;

public class SubmenuExecuterCommand : IMenuCommand
{
    private readonly IMenu submenu;

    public string Description { get; }

    public SubmenuExecuterCommand(string description, IMenu submenu)
    {
        Description = description;
        this.submenu = submenu;
    }

    public void Execute()
    {
        submenu.Start();
    }
}