using System;

namespace Quiz;

public static class Constants
{
    public static readonly string QuizLogo = "\\\\\\Викторина///";
    public static readonly string UsersXmlPath = Environment.CurrentDirectory + "\\Users.xml";
    public static readonly string GeographyXmlPath = Environment.CurrentDirectory + "\\Geography.xml";
    public static readonly string HistoryXmlPath = Environment.CurrentDirectory + "\\History.xml";
    public static readonly string BiologyXmlPath = Environment.CurrentDirectory + "\\Biology.xml";
    public static readonly string AdminLogin = "Admin";
    public static readonly int QuestionsInRound = 20;
    public static readonly int MaxUsersInRating = 20;
    public static readonly int MaxPoints = 20;
    public static readonly int AdditionalCommandsNumber = 5;
}