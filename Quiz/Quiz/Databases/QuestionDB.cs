using Quiz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz.Databases;

public class QuestionDB : IQuestionDB
{
    public List<Question> Questions { get; }

    public QuestionDB(List<Question> questions)
    {
        Questions = questions;
    }

    public void Add(Question question)
    {
        if (Questions.Any(q => q.QuestionText == question.QuestionText))
            throw new Exception("Такой вопрос уже существует!");

        Questions.Add(question);
    }

    public void Remove(Question question)
    {
        if (!Questions.Any(q => q.QuestionText == question.QuestionText))
            throw new Exception("Такого вопроса не существует!");

        Questions.Remove(question);
    }
}