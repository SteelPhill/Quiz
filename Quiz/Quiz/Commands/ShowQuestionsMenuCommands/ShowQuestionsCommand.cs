using Quiz.Databases;
using Quiz.Helpers;
using Quiz.Menus.ConsoleMenu;
using System;

namespace Quiz.Commands.ShowQuestionsMenuCommands;

public class ShowQuestionsCommand : IMenuCommand
{
    private readonly IQuestionDB questionDB;

    public string Description { get; }

    public ShowQuestionsCommand(string description, IQuestionDB questionDB)
    {
        Description = description;
        this.questionDB = questionDB;
    }

    public void Execute()
    {
        Console.WriteLine($"Тема: {Description}");
        Console.WriteLine();

        Console.WriteLine("Список вопросов:");

        foreach (var question in questionDB.Questions)
        {
            Console.WriteLine();
            Console.WriteLine($"Вопрос: {question.QuestionText}");
            Console.WriteLine("Варианты ответа:");

            foreach (var answer in question.Answers)
            {
                if (answer.isCorrect)
                    Console.Write("Правильный:   ");
                else
                    Console.Write("Неправильный: ");

                Console.WriteLine(answer.answer);
            }
        }

        ConsoleWaiting.WaitAnyKey();
    }
}