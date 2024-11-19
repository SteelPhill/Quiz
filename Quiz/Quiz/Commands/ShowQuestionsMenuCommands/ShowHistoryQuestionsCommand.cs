using Quiz.Databases;

namespace Quiz.Commands.ShowQuestionsMenuCommands;

public class ShowHistoryQuestionsCommand : ShowQuestionsCommand
{
    public ShowHistoryQuestionsCommand(string description, IQuestionDB historyQuestionDB) : base(description, historyQuestionDB) { }
}