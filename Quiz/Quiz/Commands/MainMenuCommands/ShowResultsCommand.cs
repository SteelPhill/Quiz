using Quiz.Helpers;
using Quiz.Menus.ConsoleMenu;
using System;

namespace Quiz.Commands.MainMenuCommands;

public class ShowResultsCommand : IMenuCommand
{
    public string Description { get; }

    public ShowResultsCommand(string description)
    {
        Description = description;
    }

    public void Execute()
    {
        Console.WriteLine($"Текущий пользователь: {Utile.CurrentUser.Login}");
        Console.WriteLine();

        Console.WriteLine("Результаты пройденных викторин:");
        Console.WriteLine();

        foreach (var quizResult in Utile.CurrentUser.Results)
        {
            Console.Write($"{quizResult.Date.ToShortDateString()} ");         
            Console.Write($"{quizResult.TopicToString()}\t-> ");
            Console.WriteLine($"{quizResult.Points} из {Constants.QuestionsInRound}");
        }

        if (Utile.CurrentUser.Results.Count == 0)
            Console.WriteLine("\tОтсутствуют!");

        ConsoleWaiting.WaitAnyKey();
    }
}