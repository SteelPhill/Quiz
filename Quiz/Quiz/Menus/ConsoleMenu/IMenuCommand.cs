namespace Quiz.Menus.ConsoleMenu;

public interface IMenuCommand
{
    string Description { get; }
    void Execute();
}