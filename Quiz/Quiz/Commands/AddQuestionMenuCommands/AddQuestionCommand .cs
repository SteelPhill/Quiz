using Quiz.Databases;
using Quiz.Entities;
using Quiz.Enums;
using Quiz.Helpers;
using Quiz.Menus.ConsoleMenu;
using System;
using System.Collections.Generic;

namespace Quiz.Commands.AddQuestionCommands;

public class AddQuestionCommand : IMenuCommand
{
    private readonly Topic topic;
    private readonly IQuestionDB questionDB;

    public string Description { get; }

    public AddQuestionCommand(string description, Topic topic, IQuestionDB questionDB)
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

        BeforeEnterTextFromConsoleWriter.Write("Введите новый вопрос");
        var newQuestion = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(newQuestion))
            return;

        Console.WriteLine();

        BeforeEnterTextFromConsoleWriter.Write("Введите правильный ответ");
        var correctAnswer = Console.ReadLine();     

        if (string.IsNullOrWhiteSpace(correctAnswer))
            return;

        var answers = new List<(bool isCorrect, string answer)>
        {
            { (true, correctAnswer) }
        };

        string incorrectAnswer;
        bool isExistingVariant;

        do
        {
            isExistingVariant = false;

            Console.WriteLine();
            BeforeEnterTextFromConsoleWriter.Write("Введите неправильный вариант ответа");
            incorrectAnswer = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(incorrectAnswer))
                break;

            foreach (var answer in answers)
                if (incorrectAnswer == answer.answer)
                    isExistingVariant = true;

            if (isExistingVariant)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: Введен существующий вариант ответа.");
                Console.WriteLine("        Вариант ответа не добавлен!");
                continue;
            }

            answers.Add((false, incorrectAnswer));

        } while (true);

        if (answers.Count <= 1)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tВопрос не добавлен!");
            Console.WriteLine();
            Console.WriteLine("Причина: Должен быть хотя бы один неправильный ответ.");
            ConsoleWaiting.WaitAnyKey();
            return;
        }

        questionDB.Add(new Question(topic, newQuestion, answers));

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("\tВопрос добавлен!");
        ConsoleWaiting.WaitAnyKey();
    }
}