using Quiz.Databases;
using Quiz.Enums;
using Quiz.Helpers;
using Quiz.Menus.ConsoleMenu;
using System;
using System.Linq;

namespace Quiz.Commands.ShowRatingMenuCommands;

public class ShowRatingCommand : IMenuCommand
{
    private readonly IUserDB userDB;
    private readonly Topic topic;

    public string Description { get; }

    public ShowRatingCommand(string description, Topic topic, IUserDB userDB)
    {
        Description = description;
        this.topic = topic;
        this.userDB = userDB;
    }

    public void Execute()
    {
        Console.WriteLine($"Текущий пользователь: {Utile.CurrentUser.Login}");
        Console.WriteLine();

        Console.WriteLine($"Тема: {Description}");
        Console.WriteLine();

        Console.WriteLine("Список 20-ти лучших пользователей:");
        Console.WriteLine();

        var users = userDB.Users
            .Where(u => u.Results.Count != 0 && u.Results
            .Any(r => r.Topic == topic))
            .ToList();

        users
            .Sort((u1, u2) => u2.Results
            .Where(r => r.Topic == topic)
            .Max(r => r.Points) - u1.Results
            .Where(r => r.Topic == topic)
            .Max(r => r.Points));

        var i = 0;
        for (; i < users.Count && i < Constants.MaxUsersInRating; i++)
        {
            Console.Write($"{i + 1}:\t{users[i].Login} -> ");
            Console.WriteLine($"{users[i].Results.Where(r => r.Topic == topic)
                .Max(r => r.Points)} из {Constants.MaxPoints}");
        }

        for (; i < Constants.MaxUsersInRating; i++)
            Console.WriteLine($"{i + 1}:");

        ConsoleWaiting.WaitAnyKey();
    }
}