using Quiz.Commands.NewQuizCommands;
using Quiz.Databases;
using Quiz.Enums;

namespace Quiz;

public class NewGeographyQuizCommand : NewQuizCommand
{
    public NewGeographyQuizCommand(
        string description, IUserDB userDB, IQuestionDB geographyQuestionDB) : base(
            description, Topic.Geography, userDB, geographyQuestionDB) { }
}