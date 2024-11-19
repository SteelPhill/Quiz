using Quiz.Databases;

namespace Quiz.Commands.ShowQuestionsMenuCommands;

public class ShowBiologyQuestionsCommand : ShowQuestionsCommand
{
    public ShowBiologyQuestionsCommand(string description, IQuestionDB biologyQuestionDB) : base(description, biologyQuestionDB) { }
}