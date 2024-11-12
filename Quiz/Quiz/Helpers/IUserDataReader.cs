using System;

namespace Quiz.Helpers;

public interface IUserDataReader
{
    bool TryReadLogin(out string login);
    bool TryReadPassword(out string password);
    bool TryReadDate(out DateTime date);
}