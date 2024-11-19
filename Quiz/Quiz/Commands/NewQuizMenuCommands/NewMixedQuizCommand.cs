using Quiz.Commands.NewQuizCommands;
using Quiz.Databases;
using Quiz.Enums;

namespace Quiz;

class NewMixedQuizCommand : NewQuizCommand
{
    public NewMixedQuizCommand(
        string description, 
        IUserDB userDB, 
        IQuestionDB 
        biologyQuestionDB, 
        IQuestionDB geographyQuestionDB, 
        IQuestionDB historyQuestionDB) : base(
            description, 
            Topic.Mixed, 
            userDB, 
            biologyQuestionDB, 
            geographyQuestionDB, 
            historyQuestionDB) { }
}