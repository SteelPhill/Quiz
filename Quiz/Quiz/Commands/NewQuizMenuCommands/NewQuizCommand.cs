using Quiz.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using Quiz.Menus.ConsoleMenu;
using Quiz.Menus.ConsoleQuestionMenu;
using Quiz.Databases;
using Quiz.Helpers;
using Quiz.Enums;

namespace Quiz.Commands.NewQuizMenuCommands;

public class NewQuizCommand : IMenuCommand
{
    private static readonly IQuestionMenu QuestionMenu = new ConsoleQuestionMenu();

    private readonly Topic topic;
    private readonly IQuestionDB[] questionDBs;

    public string Description { get; }

    public NewQuizCommand(string description, Topic topic, params IQuestionDB[] questionDBs)
    {
        Description = description;
        this.topic = topic;
        this.questionDBs = questionDBs;
    }

    private void QuestionsInitialize(out List<Question> questions)
    {
        questions = new List<Question>();

        foreach (var questionDB in questionDBs)
            questions = questions.Concat(questionDB.Questions).ToList();
    }

    public void Execute()
    {
        QuestionsInitialize(out var questions);
        
        if (questions.Count < Constants.QuestionsInRound)
            throw new Exception("В настоящий момент пройти викторину по данной теме невозможно!" +
                $"{Environment.NewLine}{Environment.NewLine}Причина: Количество существующих вопросов меньше 20-ти.");

        var points = 0;
        Question question;
        int questionIndex;

        for (var i = 1; i <= Constants.QuestionsInRound; i++)
        {
            questionIndex = Utile.Random.Next(0, questions.Count);

            question = questions[questionIndex];

            question.Answers = question.Answers.OrderBy(x => Utile.Random.Next()).ToList();

            if (QuestionMenu.IsCorrect(question, i))
                points++;

            questions.Remove(question);

            ConsoleWaiting.WaitAnyKey();
        }

        Utile.CurrentUser.AddQuizResult(new QuizResult(DateTime.Now, topic, points));

        Console.Clear();
        Console.WriteLine("Викторина окончена!");
        Console.WriteLine();
        Console.WriteLine($"Правильных ответов: {points}");
        ConsoleWaiting.WaitAnyKey();
    }
}