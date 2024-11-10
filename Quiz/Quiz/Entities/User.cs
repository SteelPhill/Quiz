using System;
using System.Collections.Generic;

namespace Quiz.Entities;

public class User
{
    public string Login { get; set; }
    public string Password { get; set; }
    public DateTime BirthDate { get; set; }
    public List<QuizResult> Results { get; set; }

    private User() { }

    public User(string login, string password, DateTime birthDate)
        : this(login, password, birthDate, new List<QuizResult>()) { }

    public User(
        string login, 
        string password, 
        DateTime birthDate,
        List<QuizResult> results)
    {
        Login = login;
        Password = password;
        BirthDate = birthDate;
        Results = results;
    }

    public void AddQuizResult(QuizResult results)
    {
        Results.Add(results);
    }
}