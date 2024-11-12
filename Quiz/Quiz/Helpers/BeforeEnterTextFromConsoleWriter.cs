using System;

namespace Quiz.Helpers;

public static class BeforeEnterTextFromConsoleWriter
{
    public static void Write(string task)
    {
        Console.WriteLine($"{task} и нажмите Enter");
        Console.WriteLine("\t     -или-");
        Console.WriteLine("Нажмите Enter для отмены действия");
        Console.WriteLine();
        Console.Write(" => ");
    }
}