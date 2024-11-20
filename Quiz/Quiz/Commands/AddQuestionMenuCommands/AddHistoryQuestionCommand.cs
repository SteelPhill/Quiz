using Quiz.Databases;
using Quiz.Enums;

namespace Quiz.Commands.AddQuestionCommands;

public class AddHistoryQuestionCommand : AddQuestionCommand
{
    public AddHistoryQuestionCommand(string description, Topic topic, IQuestionDB historyQuestionDB) : base(
        description, topic, historyQuestionDB) { }
}