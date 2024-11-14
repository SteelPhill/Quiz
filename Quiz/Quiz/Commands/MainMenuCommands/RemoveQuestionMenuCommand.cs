using Quiz.Menus.ConsoleMenu;

namespace Quiz.Commands.MainMenuCommands;

public class RemoveQuestionMenuCommand : IMenuCommand
{
    private readonly IMenu removeQuestionMenu;

    public string Description { get; }

    public RemoveQuestionMenuCommand(string description, IMenu removeQuestionMenu)
    { 
        Description = description;
        this.removeQuestionMenu = removeQuestionMenu;
    }

    public void Execute()
    {
        removeQuestionMenu.Start();
    }
}