using Quiz.Databases;
using Quiz.Enums;

namespace Quiz.Commands.RemoveQuestionMenuCommands;

public class RemoveBiologyQuestionCommand : RemoveQuestionCommand
{
    public RemoveBiologyQuestionCommand(string description, Topic topic, IQuestionDB biologyQuestionDB) : base(
        description, topic, biologyQuestionDB) { }
}