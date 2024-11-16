using Quiz.Commands.NewQuizCommands;
using Quiz.Databases;
using Quiz.Enums;

namespace Quiz;

public class NewBiologyQuizCommand : NewQuizCommand
{
    public NewBiologyQuizCommand(
        string description, IUserDB userDB, IQuestionDB biologyQuestionDB) : base(
            description, Topic.Biology, userDB, biologyQuestionDB) { }
}