using Quiz.Entities;
using Quiz.Enums;
using Quiz.Helpers;
using System;
using System.Collections.Generic;

namespace Quiz;

public static class Utile
{
    public static readonly Random Random = new();
    public static readonly IUserDataReader UserDataReader = new ConsoleUserDataReader();
    public static readonly ITextEncryptor TextEncryptor = new Sha256TextEncryptor();
    public static readonly ISerializeHelper SerializeHelper = new XmlSerializeHelper();
    public static readonly IColorTextWriter BlackOnWhiteTextWriter = 
        new ConsoleColorTextWriter(ConsoleColor.White, ConsoleColor.Black);

    public static readonly Dictionary<Topic, string> TopicsStringValues = new()
    {
        { Topic.Biology, "Биология" },
        { Topic.Geography, "География" },
        { Topic.History, "История" },
        { Topic.Mixed, "Смешанная" }
    };

    public static User CurrentUser { get; set; }
}