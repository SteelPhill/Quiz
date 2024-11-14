using Quiz.Menus.ConsoleMenu;

namespace Quiz.Commands.MainMenuCommands;

public class ShowRatingMenuCommand : IMenuCommand
{
    private readonly IMenu showRatingMenu;

    public string Description { get; }

    public ShowRatingMenuCommand(string description, IMenu showRatingMenu)
    {
        Description = description;
        this.showRatingMenu = showRatingMenu;
    }

    public void Execute()
    {
        showRatingMenu.Start();
    }
}