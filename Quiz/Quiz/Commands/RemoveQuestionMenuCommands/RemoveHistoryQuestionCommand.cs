using Quiz.Databases;
using Quiz.Enums;

namespace Quiz.Commands.RemoveQuestionCommands;

public class RemoveHistoryQuestionCommand : RemoveQuestionCommand
{
    public RemoveHistoryQuestionCommand(string description, Topic topic, IQuestionDB historyQuestionDB) : base(
        description, topic, historyQuestionDB) { }
}