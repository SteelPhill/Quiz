using Quiz.Databases;
using Quiz.Enums;

namespace Quiz.Commands.AddQuestionMenuCommands;

public class AddGeographyQuestionCommand : AddQuestionCommand
{
    public AddGeographyQuestionCommand(string description, Topic topic, IQuestionDB geographyQuestionDB) : base(
        description, topic, geographyQuestionDB) { }
}