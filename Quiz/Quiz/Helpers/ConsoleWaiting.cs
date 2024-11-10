using System;

namespace Quiz.Helpers;

public static class ConsoleWaiting
{
    public static void WaitAnyKey()
    {
        Console.WriteLine();
        Console.WriteLine("Нажмите любую клавишу...");
        Console.ReadKey();
    }
}