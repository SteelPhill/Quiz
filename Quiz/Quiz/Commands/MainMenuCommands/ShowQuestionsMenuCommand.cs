using Quiz.Menus.ConsoleMenu;

namespace Quiz.Commands.MainMenuCommands;

public class ShowQuestionsMenuCommand : IMenuCommand
{
    private readonly IMenu showQuestionsMenu;

    public string Description { get; }

    public ShowQuestionsMenuCommand(string description, IMenu showQuestionsMenu)
    {
        Description = description;
        this.showQuestionsMenu = showQuestionsMenu;
    }

    public void Execute()
    {
        showQuestionsMenu.Start();
    }
}