using System;
using System.Collections.Generic;

namespace Quiz.Entities;

public class Question
{
    public Topic Topic { get; set; }
    public string QuestionText { get; set; }
    public List<(bool isCorrect, string answer)> Answers { get; set; }

    public Question() : this(default, string.Empty, new List<(bool, string)>()) { }

    public Question(
        Topic topic,
        string questionText,
        List<(bool isCorrect, string answer)> answers)
    {
        Topic = topic;
        QuestionText = questionText;
        Answers = answers;
    }

    public string TopicToString()
    {
        if (Utile.TopicsStringValues.TryGetValue(Topic, out var result))
            return result;

        throw new ArgumentOutOfRangeException();
    }
}