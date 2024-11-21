using Quiz.Databases;
using Quiz.Enums;

namespace Quiz.Commands.RemoveQuestionCommands;

public class RemoveGeographyQuestionCommand : RemoveQuestionCommand
{
    public RemoveGeographyQuestionCommand(string description, Topic topic, IQuestionDB geographyQuestionDB) : base(
        description, topic, geographyQuestionDB) { }
}