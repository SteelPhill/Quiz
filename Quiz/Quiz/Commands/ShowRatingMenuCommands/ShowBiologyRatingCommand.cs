using Quiz.Databases;
using Quiz.Enums;

namespace Quiz.Commands.ShowRatingMenuCommands;

public class ShowBiologyRatingCommand : ShowRatingCommand
{
    public ShowBiologyRatingCommand(string description, Topic topic, IUserDB userDB) : base(
        description, topic, userDB) { }
}