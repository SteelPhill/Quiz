using Quiz.Commands.NewQuizCommands;
using Quiz.Databases;
using Quiz.Enums;

namespace Quiz;

public class NewHistoryQuizCommand : NewQuizCommand
{
    public NewHistoryQuizCommand(string description, IUserDB userDB, IQuestionDB historyQuestionDB) : base(
        description, Topic.History, userDB, historyQuestionDB) { }
}