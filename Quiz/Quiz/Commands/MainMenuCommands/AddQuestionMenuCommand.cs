using Quiz.Menus.ConsoleMenu;

namespace Quiz.Commands.MainMenuCommands;

public class AddQuestionMenuCommand : IMenuCommand
{
    private readonly IMenu addQuestionMenu;

    public string Description { get; }

    public AddQuestionMenuCommand(string description, IMenu addQuestionMenu)
    {
        Description = description;
        this.addQuestionMenu = addQuestionMenu;
    }

    public void Execute()
    {
        addQuestionMenu.Start();
    }
}