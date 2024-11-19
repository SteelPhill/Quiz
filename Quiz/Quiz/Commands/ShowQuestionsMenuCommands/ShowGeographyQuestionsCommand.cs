using Quiz.Databases;

namespace Quiz.Commands.ShowQuestionsMenuCommands;

public class ShowGeographyQuestionsCommand : ShowQuestionsCommand
{
    public ShowGeographyQuestionsCommand(string description, IQuestionDB geographyQuestionDB) : base(description, geographyQuestionDB) { }
}