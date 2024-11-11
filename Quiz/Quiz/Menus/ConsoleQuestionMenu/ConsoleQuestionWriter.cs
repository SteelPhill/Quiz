using Quiz.Entities;
using System;

namespace Quiz.Menus.ConsoleQuestionMenu;

public class ConsoleQuestionWriter : IQuestionWriter
{
    public void Write(ref int selector, Question question, int questionNumber)
    {
        Console.WriteLine($"Тема: {question.TopicToString()}");
        Console.WriteLine();

        Console.WriteLine($"Вопрос №{questionNumber}: {question.QuestionText}");
        Console.WriteLine();

        Console.WriteLine("Варианты ответа:");
        Console.WriteLine();

        for (var i = 0; i < question.Answers.Count; i++)
        {
            if (selector == i)
                Utile.BlackOnWhiteTextWriter.WriteLine(question.Answers[i].answer);
            else
                Console.WriteLine(question.Answers[i].answer);
        }

        Console.WriteLine();
        Console.WriteLine("Для того чтобы прервать викторину, нажмите Esc");
    }
}