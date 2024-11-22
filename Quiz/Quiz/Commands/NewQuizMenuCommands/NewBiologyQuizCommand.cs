using Quiz.Databases;
using Quiz.Enums;

namespace Quiz.Commands.NewQuizMenuCommands;

public class NewBiologyQuizCommand : NewQuizCommand
{
    public NewBiologyQuizCommand(string description, IQuestionDB biologyQuestionDB) : base(
        description, Topic.Biology, biologyQuestionDB) { }
}