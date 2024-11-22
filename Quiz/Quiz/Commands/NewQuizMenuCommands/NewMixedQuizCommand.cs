using Quiz.Databases;
using Quiz.Enums;

namespace Quiz.Commands.NewQuizMenuCommands;

class NewMixedQuizCommand : NewQuizCommand
{
    public NewMixedQuizCommand(
        string description, 
        IQuestionDB biologyQuestionDB, 
        IQuestionDB geographyQuestionDB, 
        IQuestionDB historyQuestionDB) : base(
            description, Topic.Mixed, biologyQuestionDB, geographyQuestionDB, historyQuestionDB) { }
}