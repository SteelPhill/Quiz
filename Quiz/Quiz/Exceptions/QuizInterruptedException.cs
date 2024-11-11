using System;

namespace Quiz.Exceptions;

public class QuizInterruptedException : Exception
{
    public QuizInterruptedException() { }
    public QuizInterruptedException(string message)
        : base(message) { }
}