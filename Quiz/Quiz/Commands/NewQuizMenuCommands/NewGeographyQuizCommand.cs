using Quiz.Databases;
using Quiz.Enums;

namespace Quiz.Commands.NewQuizMenuCommands;

public class NewGeographyQuizCommand : NewQuizCommand
{
    public NewGeographyQuizCommand(string description, IQuestionDB geographyQuestionDB) : base(
        description, Topic.Geography, geographyQuestionDB) { }
}