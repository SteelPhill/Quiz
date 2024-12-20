﻿using Quiz.Databases;
using Quiz.Enums;

namespace Quiz.Commands.AddQuestionMenuCommands;

public class AddBiologyQuestionCommand : AddQuestionCommand
{
    public AddBiologyQuestionCommand(string description, Topic topic, IQuestionDB biologyQuestionDB) : base(
        description, topic, biologyQuestionDB) { }
}