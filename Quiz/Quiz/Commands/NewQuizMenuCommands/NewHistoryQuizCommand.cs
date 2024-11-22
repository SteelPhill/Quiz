using Quiz.Databases;
using Quiz.Enums;

namespace Quiz.Commands.NewQuizMenuCommands;

public class NewHistoryQuizCommand : NewQuizCommand
{
    public NewHistoryQuizCommand(string description, IQuestionDB historyQuestionDB) : base(
        description, Topic.History, historyQuestionDB) { }
}