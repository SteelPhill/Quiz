using System;

namespace Quiz.Exceptions;

public class BackToPreviousMenuException : Exception
{
    public BackToPreviousMenuException() { }
    public BackToPreviousMenuException(string message) : base(message) { }
}