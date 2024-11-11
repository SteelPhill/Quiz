using Quiz.Entities;
using System;

namespace Quiz.Menus.ConsoleQuestionMenu;

public class ConsoleQuestionMenu : IQuestionMenu
{
    private static readonly IQuestionSelector QuestionSelector = 
        new ConsoleQuestionSelector();

    public bool IsCorrect(Question question, int questionNumber)
    {
        var selector = 0;

        QuestionSelector.Select(ref selector, question, questionNumber);

        Console.Clear();

        if (question.Answers[selector].isCorrect)
        {
            Console.WriteLine();
            Console.WriteLine("\tПравильно!");
            return true;
        }

        Console.WriteLine();
        Console.WriteLine("\tОшибка!");
        Console.WriteLine();
        Console.WriteLine($"Правильный ответ: {question.Answers
            .Find(a => a.isCorrect).answer}");
        return false;
    }
}