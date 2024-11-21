using Quiz.Databases;
using Quiz.Enums;
using Quiz.Helpers;
using Quiz.Menus.ConsoleMenu;
using System;

namespace Quiz.Commands.RemoveQuestionCommands;

public class RemoveQuestionCommand : IMenuCommand
{
    private readonly Topic topic;
    private readonly IQuestionDB questionDB;

    public string Description { get; }

    public RemoveQuestionCommand(string description, Topic topic, IQuestionDB questionDB)
    {
        Description = description;
        this.topic = topic;
        this.questionDB = questionDB;
    }

    public void Execute()
    {
        Console.Write("Тема: ");
        foreach (var t in Utile.TopicsStringValues)
            if (topic == t.Key)
                Console.WriteLine(t.Value);

        Console.WriteLine();

        Console.WriteLine("Список вопросов:");
        Console.WriteLine();

        for (var i = 0; i < questionDB.Questions.Count; i++)
            Console.WriteLine($"{i + 1}:\t{questionDB.Questions[i].QuestionText}");

        Console.WriteLine();
 
        BeforeEnterTextFromConsoleWriter.Write("Введите номер вопроса из списка");
        var questionNumber = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(questionNumber))
            return;

        if (int.TryParse(questionNumber, out var index))
        {
            if (index - 1 < 1 || index - 1 > questionDB.Questions.Count - 1)
                throw new Exception("Вопроса под таким номером нет!");

            questionDB.Remove(questionDB.Questions[index - 1]);

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tВопрос удалён!");
            ConsoleWaiting.WaitAnyKey();
        }
    }
}