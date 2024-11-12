using Quiz.Entities;
using System.Collections.Generic;

namespace Quiz.Databases;

public interface IQuestionDB
{
    List<Question> Questions { get; }

    void Add(Question question);
    void Remove(Question question);
}