using Quiz.Enums;
using System;

namespace Quiz.Entities;

public class QuizResult
{
    public DateTime Date { get; set; }
    public Topic Topic { get; set; }
    public int Points { get; set; }

    private QuizResult() { }

    public QuizResult(DateTime date, Topic topic, int points)
    {
        Date = date;
        Topic = topic;
        Points = points;
    }

    public string TopicToString()
    {
        if (Utile.TopicsStringValues.TryGetValue(Topic, out var result))
            return result;

        throw new ArgumentOutOfRangeException();
    }
}