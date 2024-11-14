using Quiz.Menus.ConsoleMenu;

namespace Quiz.Commands.MainMenuCommands;

public class SettingsMenuCommand : IMenuCommand
{
    private readonly IMenu settingMenu;

    public string Description { get; }

    public SettingsMenuCommand(string description, IMenu settingMenu)
    {
        Description = description;
        this.settingMenu = settingMenu;
    }

    public void Execute()
    {
        settingMenu.Start();
    }
}