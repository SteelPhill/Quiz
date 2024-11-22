using System;

namespace Quiz.Helpers;

public class ConsoleUserDataReader : IUserDataReader
{
    public bool TryReadLogin(out string login)
    {
        login = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(login))
        {
            login = string.Empty;
            return false;
        }

        login.Trim(' ', '\t', '\n', '\r');
        return true;
    }

    public bool TryReadPassword(out string password)
    {
        password = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(password))
        {
            password = string.Empty;
            return false;
        }

        password = Utile.TextEncryptor.Encrypt(password.Trim(' ', '\t', '\n', '\r'));
        return true;
    }

    public bool TryReadDate(out DateTime date)
    {
        var line = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(line))
        {
            date = default;
            return false;
        }

        if (DateTime.TryParse(line.Trim(' ', '\t', '\n', '\r'), out date))
            return true;

        throw new Exception("Некорректная дата рождения!");
    }
}