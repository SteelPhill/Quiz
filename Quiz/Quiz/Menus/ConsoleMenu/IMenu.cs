namespace Quiz.Menus.ConsoleMenu;

public interface IMenu
{
    void AddCommand(IMenuCommand command);
    void RemoveCommand(IMenuCommand command);
    void RemoveLastCommand();
    void Start();
}