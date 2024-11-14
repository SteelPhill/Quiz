using Quiz.Menus.ConsoleMenu;

namespace Quiz.Commands.MainMenuCommands;

public class NewQuizMenuCommand : IMenuCommand
{
    private readonly IMenu newQuizMenu;

    public string Description { get; }

    public NewQuizMenuCommand(string description, IMenu newQuizMenu)
    {
        Description = description;
        this.newQuizMenu = newQuizMenu;
    }

    public void Execute()
    {
        newQuizMenu.Start();
    }
}