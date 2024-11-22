using Quiz.Entities;
using Quiz.Exceptions;
using System;

namespace Quiz.Menus.ConsoleQuestionMenu;

public class ConsoleQuestionSelector : IQuestionSelector
{
    private static readonly IQuestionWriter QuestionWriter = new ConsoleQuestionWriter();

    public void Select(ref int selector, Question question, int questionNumber)
    {
        do
        {
            Console.Clear();
            QuestionWriter.Write(ref selector, question, questionNumber);

            var key = Console.ReadKey(intercept: true).Key;

            if (key == ConsoleKey.DownArrow && selector < question.Answers.Count - 1)
                selector++;
            else if (key == ConsoleKey.UpArrow && selector > 0)
                selector--;
            else if (key == ConsoleKey.Enter)
                return;
            else if (key == ConsoleKey.Escape)
                throw new QuizInterruptedException();

        } while (true);
    }
}